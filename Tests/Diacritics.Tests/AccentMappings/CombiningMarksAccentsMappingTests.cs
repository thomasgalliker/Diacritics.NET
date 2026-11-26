using System.Linq;
using System.Text;
using Diacritics.AccentMappings;
using Diacritics.Tests.Import;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class CombiningMarksAccentsMappingTests
    {
        [Theory]
        [InlineData("Cafe\u0301", "Cafe")] // Combining acute accent
        [InlineData("n\u0303", "n")] // Combining tilde
        [InlineData("a\u0308o\u0308u\u0308", "aou")] // Combining diaeresis
        [InlineData("c\u0327", "c")] // Combining cedilla
        [InlineData("i\u0307", "i")] // Combining dot above (Azerbaijani, Lithuanian)
        public void RemoveDiacritics_LettersWithCombiningMarks_ReturnsLettersWithoutMarks(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new CombiningMarksAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }

        [Fact]
        public void Mapping_AllCombiningDiacriticalMarks_MapsToEmptyString()
        {
            // Arrange
            var (first, last) = UnicodeCodeGeneratorTests.CombiningDiacriticalMarksBlock;
            var combiningMarks = Enumerable.Range(first, last - first + 1).Select(cp => (char)cp).ToList();
            var mapping = new CombiningMarksAccentsMapping().Mapping;

            // Act
            var replacements = combiningMarks.Select(c => mapping.TryGetValue(c, out var r) ? r.Base : null).ToList();

            // Assert
            replacements.Should().OnlyContain(r => r == string.Empty);
        }

        [Theory]
        [InlineData("Crème brûlée à la française", "Creme brulee a la francaise")]
        [InlineData("Ϊ\u0301", "Ι")] // Greek capital iota with dialytika and tonos (decomposed)
        [InlineData("Ελληνικά", "Ελληνικα")]
        public void RemoveDiacritics_DefaultMapperWithDecomposedText_ReturnsTextWithoutDiacritics(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DefaultDiacriticsMapper();
            var decomposedInput = input.Normalize(NormalizationForm.FormD);

            // Act
            var output = mapper.RemoveDiacritics(decomposedInput);

            // Assert
            output.Should().Be(expectedOutput);
        }
    }
}