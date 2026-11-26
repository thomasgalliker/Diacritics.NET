using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Diacritics.AccentMappings;
using Diacritics.Tests.Import;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class UnicodeAccentsMappingTests
    {
        [Fact]
        public void RemoveDiacritics_DefaultMapperWithAllDecomposableLetters_ReturnsLettersWithoutCombiningMarks()
        {
            // Arrange
            var mapper = new DefaultDiacriticsMapper();

            // Act
            var unmapped = GetUnmappedDecomposableLetters(mapper);

            // Assert
            unmapped.Should().BeEmpty();
        }

        [Fact]
        public void RemoveDiacritics_UnicodeMappingWithAllDecomposableLetters_ReturnsLettersWithoutCombiningMarks()
        {
            // Arrange
            var mapper = new DiacriticsMapper(new UnicodeAccentsMapping());

            // Act
            var unmapped = GetUnmappedDecomposableLetters(mapper);

            // Assert
            unmapped.Should().BeEmpty();
        }

        [Theory]
        [InlineData("Ĉiuĵaŭde ŝi manĝas ĥoraĉe", "Ciujaude si mangas horace")] // Esperanto
        [InlineData("Ċ ċ Ġ ġ", "C c G g")] // Maltese
        [InlineData("Ţ ţ", "T t")] // Romanian (legacy cedilla)
        [InlineData("Ŗ ŗ", "R r")] // Latvian (pre-1946 orthography)
        [InlineData("Ǎǎ Ǐǐ Ǒǒ Ǔǔ Ǖǖ", "Aa Ii Oo Uu Uu")] // Pinyin
        [InlineData("Ḍḍ Ḥḥ Ṣṣ Ṭṭ", "Dd Hh Ss Tt")] // Transliteration (e.g. Arabic, Sanskrit)
        [InlineData("Ǣ Ǽ Ǿ ẛ", "Ae Ae O s")] // Decomposes into letters which are mapped themselves
        [InlineData("Ἀθῆναι", "Αθηναι")] // Polytonic Greek
        [InlineData("ᾳ ῥ ὦ", "α ρ ω")] // Polytonic Greek
        [InlineData("Ѐ ѐ Ѝ ѝ Ӑ ӑ Ӧ ӧ", "Е е И и А а О о")] // Cyrillic
        public void RemoveDiacritics_DefaultMapperWithLettersNotCoveredByLanguages_ReturnsBaseLetters(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DefaultDiacriticsMapper();

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }

        /// <summary>
        /// Returns all letters with a canonical decomposition (NFD) which still contain a combining mark after removing diacritics.
        /// </summary>
        private static List<string> GetUnmappedDecomposableLetters(IDiacriticsMapper mapper)
        {
            return UnicodeCodeGeneratorTests.DecomposableLetterBlocks
                .SelectMany(b => Enumerable.Range(b.First, b.Last - b.First + 1))
                .Select(cp => ((char)cp).ToString())
                .Where(s => char.IsLetter(s[0]) && s.Normalize(NormalizationForm.FormD).Length > 1)
                .Where(s => HasCombiningMark(mapper.RemoveDiacritics(s)))
                .Select(s => $"{s} (U+{(int)s[0]:X4})")
                .ToList();
        }

        private static bool HasCombiningMark(string? value)
        {
            return value is null || value
                .Normalize(NormalizationForm.FormD)
                .Any(c => CharUnicodeInfo.GetUnicodeCategory(c) == UnicodeCategory.NonSpacingMark);
        }
    }
}