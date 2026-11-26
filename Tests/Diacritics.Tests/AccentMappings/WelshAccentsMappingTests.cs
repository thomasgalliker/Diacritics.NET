using Diacritics.AccentMappings;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class WelshAccentsMappingTests
    {
        [Theory]
        [InlineData("Mae'r gŵr yn yfed dŵr yn y tŷ", "Mae'r gwr yn yfed dwr yn y ty")]
        [InlineData("ẂẀŴẄÝỲŶŸ", "WWWWYYYY")]
        public void RemoveDiacritics_WelshText_ReturnsTextWithoutDiacritics(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new WelshAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }
    }
}