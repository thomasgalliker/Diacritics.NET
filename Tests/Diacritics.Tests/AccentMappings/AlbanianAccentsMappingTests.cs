using Diacritics.AccentMappings;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class AlbanianAccentsMappingTests
    {
        [Theory]
        [InlineData("Çdo ditë është e bukur", "Cdo dite eshte e bukur")]
        [InlineData("ÇËçë", "CEce")]
        public void RemoveDiacritics_AlbanianText_ReturnsTextWithoutDiacritics(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new AlbanianAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }
    }
}