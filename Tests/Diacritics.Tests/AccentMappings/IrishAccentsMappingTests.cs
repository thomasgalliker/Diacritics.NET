using Diacritics.AccentMappings;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class IrishAccentsMappingTests
    {
        [Theory]
        [InlineData("Dia duit, conas atá tú? Is é mo ainm Seán", "Dia duit, conas ata tu? Is e mo ainm Sean")]
        [InlineData("ÁÉÍÓÚ", "AEIOU")]
        public void RemoveDiacritics_IrishText_ReturnsTextWithoutDiacritics(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new IrishAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }
    }
}