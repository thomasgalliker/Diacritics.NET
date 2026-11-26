using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Diacritics.Tests.Import
{
    public class AccentsMappingDataJsonConverter : JsonConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            var token = JToken.Load(reader);
            var list = (Activator.CreateInstance(objectType) as IList)!;

            if (token.Type != JTokenType.Object)
            {
                return list;
            }

            foreach (var property in token.Children<JProperty>())
            {
                var source = property.Name;
                var value = property.Value;

                if (source.Length == 1)
                {
                    list.Add(ReadMappingData(source[0], value));
                }
                else
                {
                    AddExpandedMappings(list, source, value);
                }
            }

            return list;
        }

        private static AccentsMappingData ReadMappingData(char source, JToken value)
        {
            var mapping = value["mapping"];
            var decomposeToken = mapping?["decompose"];

            return new AccentsMappingData
            {
                Source = source,
                Base = mapping?["base"]?.Value<string>(),
                Decompose = decomposeToken?["value"]?.Value<string>(),
                DecomposeTitle = decomposeToken?["titleCase"]?.Value<string>(),
                Case = value["case"]?.Value<string>(),
            };
        }

        /// <summary>
        /// Some languages (e.g. Japanese) list several characters in one key, e.g. "がガ" with base "かカ".
        /// These keys are expanded position by position into single character mappings.
        /// Keys which consist of a base letter plus combining marks (e.g. Arabic "بَ" or Greek "Ϊ́") cannot be represented
        /// as char mappings and are skipped; they are covered by mapping the combining marks to an empty string.
        /// </summary>
        private static void AddExpandedMappings(IList list, string source, JToken value)
        {
            var mapping = value["mapping"];
            var @base = mapping?["base"]?.Value<string>();

            if (@base == null || @base.Length != source.Length || mapping?["decompose"] != null || source.Any(IsCombiningMark))
            {
                return;
            }

            for (var i = 0; i < source.Length; i++)
            {
                if (source[i] == @base[i])
                {
                    continue;
                }

                list.Add(new AccentsMappingData
                {
                    Source = source[i],
                    Base = @base[i].ToString(),
                    Case = value["case"]?.Value<string>(),
                });
            }
        }

        private static bool IsCombiningMark(char c)
        {
            var category = CharUnicodeInfo.GetUnicodeCategory(c);
            return category is UnicodeCategory.NonSpacingMark
                or UnicodeCategory.SpacingCombiningMark
                or UnicodeCategory.EnclosingMark;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsGenericType && objectType.GetGenericTypeDefinition() == typeof(List<>);
        }

        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) => throw new NotImplementedException();
    }
}
