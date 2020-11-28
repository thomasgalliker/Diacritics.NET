using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Newtonsoft.Json;
using Xunit;

namespace Diacritics.Tests.Import
{
    /// <summary>
    /// In order to keep accent mapping in sync with the very complete database https://github.com/diacritics/database/tree/master/src
    /// the following unit test is used to import accent mappings and refresh implementations of IAccentMapping.
    /// </summary>
    public class ImportCodeGeneratorTests
    {
        private static readonly string AccentMappingsFolder = "..\\..\\..\\..\\..\\Diacritics\\AccentMappings";

        [Trait("Category", "Manual")]
        [Theory]
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
                ;

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
                this.Add(@"ar/ar.json", "ArabicAccentsMapping");
                this.Add(@"az/az.json", "AzerbaijaniAccentsMapping");
                this.Add(@"be/be.json", "BelarusianAccentsMapping");
                this.Add(@"bg/bg.json", "BulgarianAccentsMapping");
                this.Add(@"bs/bs.json", "BosnianAccentsMapping");
                this.Add(@"ca/ca.json", "CatalanAccentsMapping");
                this.Add(@"hr/hr.json", "CroatianAccentsMapping");
                this.Add(@"cs/cs.json", "CzechAccentsMapping");
                this.Add(@"nl/nl.json", "DutchAccentsMapping");
                this.Add(@"et/et.json", "EstonianAccentsMapping");
                this.Add(@"fi/fi.json", "FinnishAccentsMapping");
                this.Add(@"fil/fil.json", "FilipinoAccentsMapping");
                this.Add(@"fr/fr.json", "FrenchAccentsMapping");
                this.Add(@"de/de.json", "GermanAccentsMapping");
                this.Add(@"el/el.json", "GreekAccentsMapping");
                this.Add(@"hu/hu.json", "HungarianAccentsMapping");
                this.Add(@"is/is.json", "IcelandicAccentsMapping");
                this.Add(@"it/it.json", "ItalianAccentsMapping");
                this.Add(@"lv/lv.json", "LatvianAccentsMapping");
                this.Add(@"pl/pl.json", "PolishAccentsMapping");
                this.Add(@"pt/pt.json", "PortugueseAccentsMapping");
                this.Add(@"ro/ro.json", "RomanianAccentsMapping");
                this.Add(@"ru/ru.json", "RussianAccentsMapping");
                this.Add(@"tr/tr.json", "TurkishAccentsMapping");
                this.Add(@"de/ch.json", "SwissGermanAccentsMapping");
                this.Add(@"sk/sk.json", "SlovakianAccentsMapping");
                this.Add(@"es/es.json", "SpanishAccentsMapping");
                this.Add(@"sv/sv.json", "SwedishAccentsMapping");
                this.Add(@"ta/ta.json", "TamilAccentsMapping");
                this.Add(@"to/to.json", "TonganAccentsMapping");
                this.Add(@"uk/uk.json", "UkarainianAccentsMapping");
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

        private static string GenerateTemplate(string className, IEnumerable<AccentsMappingData> mappings)
        {
            var mappingsDump = string.Join($",{Environment.NewLine}", mappings.Select(m =>
            {
                var paramBase = m.Base != null ? $"\"{m.Base}\"" : "null";
                var paramDecompose = m.Decompose != null ? $"\"{m.Decompose}\"" : "null";
                var paramDecomposeTitle = m.DecomposeTitle != null ? $"\"{m.DecomposeTitle}\"" : "null";
                return $"\t\t\t{{ '{m.Source}', new MappingReplacement({paramBase}, {paramDecompose}, {paramDecomposeTitle}) }}";
            }));

            var content = @$"using System.Collections.Generic;

namespace Diacritics.AccentMappings
{{
    public partial class {className} : IAccentMapping
    {{
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {{
{mappingsDump}
        }};

        public IDictionary<char, MappingReplacement> Mapping {{ get {{ return MappingDictionary; }} }}
    }}
}}";

            return content;
        }

    }
}
