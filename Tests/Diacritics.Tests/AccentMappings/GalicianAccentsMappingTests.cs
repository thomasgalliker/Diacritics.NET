using Diacritics.AccentMappings;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class GalicianAccentsMappingTests
    {
        [Theory]
        [InlineData("Coruña, Ourense e Lugo están en Galicia", "Coruna, Ourense e Lugo estan en Galicia")]
        [InlineData("pingüín", "pinguin")]
        public void RemoveDiacritics_GalicianText_ReturnsTextWithoutDiacritics(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new GalicianAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }
    }
}