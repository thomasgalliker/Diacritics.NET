using Diacritics.AccentMappings;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class ArabicAccentsMappingTests
    {
        [Theory]
        [InlineData("آأإ", "ااا")]
        [InlineData("ؤئى", "ويي")]
        public void RemoveDiacritics_LettersWithHamzaOrMadda_ReturnsBaseLetters(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new ArabicAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }

        [Theory]
        [InlineData("بَ", "ب")] // Fatha
        [InlineData("بً", "ب")] // Fathatan
        [InlineData("بّ", "ب")] // Shadda
        [InlineData("بْ", "ب")] // Sukun
        [InlineData("مُحَمَّد", "محمد")]
        [InlineData("هٰذَا", "هذا")] // Superscript alef
        public void RemoveDiacritics_LettersWithHarakat_ReturnsLettersWithoutHarakat(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new ArabicAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }
    }
}