using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Diacritics.Tests.Import
{
    /// <summary>
    /// Generates accent mappings which are derived from the Unicode character database rather than from a specific language.
    /// Run these tests manually to refresh <c>UnicodeAccentsMapping</c> and <c>CombiningMarksAccentsMapping</c>.
    /// </summary>
    [Trait("Category", "Manual")]
    public class UnicodeCodeGeneratorTests
    {
        /// <summary>
        /// The Unicode blocks whose letters are decomposed into a base letter and combining marks.
        /// </summary>
        internal static readonly (int First, int Last)[] DecomposableLetterBlocks =
        {
            (0x00C0, 0x00FF), // Latin-1 Supplement (letters)
            (0x0100, 0x017F), // Latin Extended-A
            (0x0180, 0x024F), // Latin Extended-B
            (0x0370, 0x03FF), // Greek and Coptic
            (0x0400, 0x04FF), // Cyrillic
            (0x1E00, 0x1EFF), // Latin Extended Additional
            (0x1F00, 0x1FFF), // Greek Extended
        };

        /// <summary>
        /// The Unicode block of the combining diacritical marks.
        /// </summary>
        internal static readonly (int First, int Last) CombiningDiacriticalMarksBlock = (0x0300, 0x036F);

        [Fact]
        public async Task GenerateUnicodeAccentsMapping()
        {
            // Decompose letters and resolve their base letters
            var mapper = new DefaultDiacriticsMapper();
            var mappings = DecomposableLetterBlocks
                .SelectMany(b => Enumerable.Range(b.First, b.Last - b.First + 1))
                .Select(cp => (char)cp)
                .Select(c => (Source: c, Base: GetBaseLetters(c, mapper)))
                .Where(m => m.Base != null)
                .Select(m => new AccentsMappingData { Source = m.Source, Base = m.Base })
                .OrderBy(m => m.Source);

            // Generate mapping file
            var fileContent = AccentMappingCodeWriter.Generate(
                "UnicodeAccentsMapping",
                mappings,
                "Maps all Latin, Greek and Cyrillic letters which have a canonical Unicode decomposition (NFD) to their base letters.");
            await WriteMappingFileAsync("UnicodeAccentsMapping", fileContent);
        }

        [Fact]
        public async Task GenerateCombiningMarksAccentsMapping()
        {
            // Map all combining marks to an empty string
            var (first, last) = CombiningDiacriticalMarksBlock;
            var mappings = Enumerable.Range(first, last - first + 1)
                .Select(cp => new AccentsMappingData { Source = (char)cp, Base = string.Empty });

            // Generate mapping file
            var fileContent = AccentMappingCodeWriter.Generate(
                "CombiningMarksAccentsMapping",
                mappings,
                "Removes the combining diacritical marks (U+0300 to U+036F), e.g. in text which is in Unicode normalization form D (NFD).");
            await WriteMappingFileAsync("CombiningMarksAccentsMapping", fileContent);
        }

        /// <summary>
        /// Returns the base letters of <paramref name="c"/> without combining marks,
        /// or <c>null</c> if <paramref name="c"/> is not a letter or has no canonical decomposition.
        /// </summary>
        private static string? GetBaseLetters(char c, IDiacriticsMapper mapper)
        {
            if (!char.IsLetter(c))
            {
                return null;
            }

            var decomposed = c.ToString().Normalize(NormalizationForm.FormD);
            if (decomposed.Length <= 1)
            {
                return null;
            }

            var baseLetters = new string(decomposed
                .Where(d => CharUnicodeInfo.GetUnicodeCategory(d) != UnicodeCategory.NonSpacingMark)
                .ToArray());

            // Resolve base letters which are mapped themselves, e.g. Ǣ -> Æ -> Ae or ẛ -> ſ -> s
            return mapper.RemoveDiacritics(baseLetters);
        }

        private static Task WriteMappingFileAsync(string className, string fileContent)
        {
            var filePath = Path.Combine(AccentMappingCodeWriter.AccentMappingsFolder, className + ".cs");
            return File.WriteAllTextAsync(filePath, fileContent);
        }
    }
}
