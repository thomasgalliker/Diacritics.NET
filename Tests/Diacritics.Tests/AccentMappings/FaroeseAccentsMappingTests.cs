using Diacritics.AccentMappings;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class FaroeseAccentsMappingTests
    {
        [Theory]
        [InlineData("Tórshavn er høvuðsstaðurin í Føroyum", "Torshavn er hovudsstadurin i Foroyum")]
        [InlineData("ÁÍÓÚÝÆØÐ", "AIOUYAeOD")]
        public void RemoveDiacritics_FaroeseText_ReturnsTextWithoutDiacritics(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new FaroeseAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }
    }
}