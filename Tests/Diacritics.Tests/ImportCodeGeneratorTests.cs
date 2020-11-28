using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Diacritics.Tests
{
    /// <summary>
    /// In order to keep accent mapping in sync with the very complete database https://github.com/diacritics/database/tree/master/src
    /// the following unit test is used to import accent mappings and refresh implementations of IAccentMapping.
    /// </summary>
    public class ImportCodeGeneratorTests
    {
        private static readonly string AccentMappingsFolder = "..\\..\\..\\..\\..\\Diacritics\\AccentMappings";

        [Trait("Category", "Manual")]
        [Theory(Skip = "Manual Test")]
        [ClassData(typeof(ImportUrls))]
        public async Task GenerateAccentMappings(string languageUrl, string className)
        {
            // Download accent mappings from diacritics database
            var url = $"https://raw.githubusercontent.com/diacritics/database/master/src/{languageUrl}";
            var accentsMapping = await ImportAccentMappingsAsync(url);
            accentsMapping.Should().NotBeNull();

            // Convert to Dictionary<char, string>
            var mappings = accentsMapping.Data
                .OrderBy(d => d.Source)
                .ToDictionary(d => d.Source, d => d.Target);

            // Generate mapping file
            var fileContent = GenerateTemplate(className, mappings);
            var filePath = Path.Combine(AccentMappingsFolder, className + ".cs");
            File.WriteAllText(filePath, fileContent);
        }

        internal class ImportUrls : TheoryData<string, string>
        {
            public ImportUrls()
            {
                this.Add(@"af/af.json", "AfrikaansAccentsMapping");
                //this.Add(@"ar/ar.json", "ArabicAccentsMapping");
                this.Add(@"az/az.json", "AzerbaijaniAccentsMapping");
                this.Add(@"be/be.json", "BelarusianAccentsMapping");
                this.Add(@"bg/bg.json", "BulgarianAccentsMapping");
                this.Add(@"bs/bs.json", "BosnianAccentsMapping");
                this.Add(@"ca/ca.json", "CatalanAccentsMapping");
                this.Add(@"fr/fr.json", "FrenchAccentsMapping");
                this.Add(@"de/de.json", "GermanAccentsMapping");
                this.Add(@"tr/tr.json", "TurkishAccentsMapping");
                this.Add(@"de/ch.json", "SwissGermanAccentsMapping");
                this.Add(@"sv/sv.json", "SwedishAccentsMapping");
                this.Add(@"ta/ta.json", "TamilAccentsMapping");
                this.Add(@"to/to.json", "TonganAccentsMapping");
                this.Add(@"ur/ur.json", "UrduAccentsMapping");
                this.Add(@"vi/vi.json", "VietnameseAccentsMapping");
            }
        }

        private static async Task<AccentsMapping> ImportAccentMappingsAsync(string url)
        {
            using (var httpClient = new HttpClient())
            {
                var json = await httpClient.GetStringAsync(url);
                return JsonConvert.DeserializeObject<AccentsMapping>(json);
            }
        }

        private static string GenerateTemplate(string className, Dictionary<char, string> mappings)
        {
            var mappingsDump = string.Join($",{Environment.NewLine}", mappings.Select(m => $"\t\t\t{{ '{m.Key}', \"{m.Value}\" }}"));

            var content = @$"using System.Collections.Generic;

namespace Diacritics.AccentMappings
{{
    public partial class {className} : IAccentMapping
    {{
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {{
{mappingsDump}
        }};

        public IDictionary<char, string> Mapping {{ get {{ return MappingDictionary; }} }}
    }}
}}";

            return content;
        }

        public class AccentsMapping
        {
            public Metadata Metadata { get; set; }

            [JsonConverter(typeof(AccentsMappingDataConverter))]
            public List<AccentsMappingData> Data { get; set; }
        }

        public class Metadata
        {
            public string Alphabet { get; set; }

            [JsonProperty("continent")]
            public ICollection<string> Continents { get; set; }

            public string Language { get; set; }

            public string LanguageNative { get; set; }
        }

        [DebuggerDisplay("Mapping '{Source}' -> '{Target}' ({Case})")]
        public class AccentsMappingData
        {
            public char Source { get; set; }

            public string Target { get; set; }

            public string Case { get; set; }
        }

        public class AccentsMappingDataConverter : JsonConverter
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

                        var childName = nameProp.Single();

                        var childValue = ((JProperty)child).Value;
                        var @case = childValue["case"].Value<string>();
                        if (@case == "upper")
                        {
                            continue;
                        }

                        var @base = childValue["mapping"]["base"].Value<string>();
                        var target = @base;
                        if (childName.ToString() == target)
                        {
                            target = childValue["mapping"]["decompose"]["value"].Value<string>();
                        }

                        var accentsMappingData = new AccentsMappingData
                        {
                            Source = childName,
                            Target = target,
                            Case = @case,
                        };

                        list.Add(accentsMappingData);
                    }
                }

                return list;

            }

            public override bool CanConvert(Type objectType)
            {
                return objectType.IsGenericType && (objectType.GetGenericTypeDefinition() == typeof(List<>));
            }
            public override bool CanWrite => false;

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => throw new NotImplementedException();
        }
    }
}
