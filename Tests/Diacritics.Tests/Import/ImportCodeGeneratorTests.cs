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
    [Trait("Category", "Manual")]
    public class ImportCodeGeneratorTests
    {
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
            var fileContent = AccentMappingCodeWriter.Generate(className, mappings);
            var filePath = Path.Combine(AccentMappingCodeWriter.AccentMappingsFolder, className + ".cs");
            await File.WriteAllTextAsync(filePath, fileContent);
        }

        internal class ImportUrls : TheoryData<string, string>
        {
            public ImportUrls()
            {
                this.Add(@"af/af.json", "AfrikaansAccentsMapping");
                this.Add(@"sq/sq.json", "AlbanianAccentsMapping");
                this.Add(@"ar/ar.json", "ArabicAccentsMapping");
                this.Add(@"az/az.json", "AzerbaijaniAccentsMapping");
                this.Add(@"eu/eu.json", "BasqueAccentsMapping");
                this.Add(@"be/be.json", "BelarusianAccentsMapping");
                this.Add(@"bs/bs.json", "BosnianAccentsMapping");
                this.Add(@"bg/bg.json", "BulgarianAccentsMapping");
                this.Add(@"ca/ca.json", "CatalanAccentsMapping");
                this.Add(@"hr/hr.json", "CroatianAccentsMapping");
                this.Add(@"cs/cs.json", "CzechAccentsMapping");
                this.Add(@"da/da.json", "DanishAccentsMapping");
                this.Add(@"nl/nl.json", "DutchAccentsMapping");
                this.Add(@"et/et.json", "EstonianAccentsMapping");
                this.Add(@"fo/fo.json", "FaroeseAccentsMapping");
                this.Add(@"fil/fil.json", "FilipinoAccentsMapping");
                this.Add(@"fi/fi.json", "FinnishAccentsMapping");
                this.Add(@"fr/fr.json", "FrenchAccentsMapping");
                this.Add(@"gl/gl.json", "GalicianAccentsMapping");
                this.Add(@"de/de.json", "GermanAccentsMapping");
                this.Add(@"el/el.json", "GreekAccentsMapping");
                this.Add(@"hu/hu.json", "HungarianAccentsMapping");
                this.Add(@"is/is.json", "IcelandicAccentsMapping");
                this.Add(@"ga/ga.json", "IrishAccentsMapping");
                this.Add(@"it/it.json", "ItalianAccentsMapping");
                this.Add(@"ja/ja.json", "JapaneseAccentsMapping");
                this.Add(@"kk/kk.json", "KazakhAccentsMapping");
                this.Add(@"ky/ky.json", "KyrgyzAccentsMapping");
                this.Add(@"lv/lv.json", "LatvianAccentsMapping");
                this.Add(@"lt/lt.json", "LithuanianAccentsMapping");
                this.Add(@"mk/mk.json", "MacedonianAccentsMapping");
                this.Add(@"mr/mr.json", "MarathiAccentsMapping");
                this.Add(@"mn/mn.json", "MongolianAccentsMapping");
                this.Add(@"nb/nb.json", "NorwegianAccentsMapping");
                this.Add(@"fa/fa.json", "PersianAccentsMapping");
                this.Add(@"pl/pl.json", "PolishAccentsMapping");
                this.Add(@"pt/pt.json", "PortugueseAccentsMapping");
                this.Add(@"ro/ro.json", "RomanianAccentsMapping");
                this.Add(@"ru/ru.json", "RussianAccentsMapping");
                this.Add(@"sr/sr.json", "SerbianAccentsMapping");
                this.Add(@"sk/sk.json", "SlovakianAccentsMapping");
                this.Add(@"sl/sl.json", "SlovenianAccentsMapping");
                this.Add(@"es/es.json", "SpanishAccentsMapping");
                this.Add(@"sv/sv.json", "SwedishAccentsMapping");
                this.Add(@"de/ch.json", "SwissGermanAccentsMapping");
                this.Add(@"ta/ta.json", "TamilAccentsMapping");
                this.Add(@"to/to.json", "TonganAccentsMapping");
                this.Add(@"tr/tr.json", "TurkishAccentsMapping");
                this.Add(@"uk/uk.json", "UkarainianAccentsMapping");
                this.Add(@"ur/ur.json", "UrduAccentsMapping");
                this.Add(@"vi/vi.json", "VietnameseAccentsMapping");
                this.Add(@"cy/cy.json", "WelshAccentsMapping");

                // Not imported:
                // - ko/ko.json: The only entry is the range placeholder "가-힣" which maps to itself.
                // - my/my.json: The only entry maps U+1026 to its own canonical decomposition.
                // - und/und.json: All entries are covered by UnicodeAccentsMapping (see UnicodeCodeGeneratorTests).
            }
        }

        private static async Task<AccentsMapping> ImportAccentMappingsAsync(string url)
        {
            using (var httpClient = new HttpClient())
            {
                var json = await httpClient.GetStringAsync(url);
                return JsonConvert.DeserializeObject<AccentsMapping>(json)!;
            }
        }
    }
}
