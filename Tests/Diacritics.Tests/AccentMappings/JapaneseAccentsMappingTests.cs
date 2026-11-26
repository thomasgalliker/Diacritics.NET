using Diacritics.AccentMappings;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class JapaneseAccentsMappingTests
    {
        [Theory]
        [InlineData("ガギグゲゴ", "カキクケコ")]
        [InlineData("がっこう", "かっこう")]
        [InlineData("パピプペポ", "ハヒフヘホ")]
        [InlineData("ヴ", "ウ")]
        [InlineData("ゞヾ", "ゝヽ")]
        public void RemoveDiacritics_KanaWithDakutenOrHandakuten_ReturnsTextWithoutDiacritics(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new JapaneseAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }
    }
}