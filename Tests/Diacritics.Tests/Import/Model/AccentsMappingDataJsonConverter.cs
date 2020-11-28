using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Diacritics.Tests.Import
{
    public class AccentsMappingDataJsonConverter : JsonConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var token = JToken.Load(reader);
            var list = Activator.CreateInstance(objectType) as System.Collections.IList;
            //var itemType = objectType.GenericTypeArguments[0];
            if (token.Type.ToString() == "Object")
            {
                foreach (var child in token.Children())
                {
                    var nameProp = ((JProperty)child).Name;
                    if (nameProp.Length > 1)
                    {
                        // Needs refactoring: Some languagues map string->string instead of char->string
                        continue;
                    }

                    var childName = nameProp[0];

                    var childValue = ((JProperty)child).Value;
                    var @case = childValue["case"].Value<string>();
                    if (@case == "upper")
                    {
                        continue;
                    }

                    var mapping = childValue["mapping"];
                    var target = mapping["base"].Value<string>();
                    var decompose = mapping["decompose"]["value"].Value<string>();

                    var accentsMappingData = new AccentsMappingData
                    {
                        Source = childName,
                        Target = target,
                        Decompose = decompose,
                        Case = @case,
                    };

                    list.Add(accentsMappingData);
                }
            }

            return list;

        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsGenericType && objectType.GetGenericTypeDefinition() == typeof(List<>);
        }
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => throw new NotImplementedException();
    }
}
