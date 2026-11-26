using Diacritics.AccentMappings;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class OtherAccentsMappingTests
    {
        [Theory]
        [InlineData("Ħal Qormi", "Hal Qormi")] // Maltese
        [InlineData("Ŧŧ", "Tt")] // Northern Sami
        [InlineData("Ǥǥ", "Gg")] // Skolt Sami
        [InlineData("Ŀŀ", "Ll")] // Catalan
        [InlineData("Ɓɓ Ɗɗ Ƙƙ Ƴƴ", "Bb Dd Kk Yy")] // Hausa
        [InlineData("Ɨɨ ƀ Ɖɖ Ƶƶ", "Ii b Dd Zz")]
        public void RemoveDiacritics_LettersWithStrokeOrHook_ReturnsBaseLetters(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new OtherAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }

        [Theory]
        [InlineData("Ĳsselmeer", "IJsselmeer")]
        [InlineData("ĳs", "ijs")]
        [InlineData("ǄǅǆǇǈǉǊǋǌǱǲǳ", "DZDzdzLJLjljNJNjnjDZDzdz")]
        [InlineData("ﬀ ﬁ ﬂ ﬃ ﬄ ﬅ ﬆ", "ff fi fl ffi ffl st st")]
        [InlineData("ﬁnal", "final")]
        public void RemoveDiacritics_DigraphsAndLigatures_ReturnsSeparateLetters(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new OtherAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }

        [Theory]
        [InlineData("ŉ", "'n")]
        [InlineData("Meſſe", "Messe")]
        public void RemoveDiacritics_OtherLetters_ReturnsBaseLetters(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new OtherAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }
    }
}