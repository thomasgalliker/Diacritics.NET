using Diacritics.AccentMappings;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class BasqueAccentsMappingTests
    {
        [Theory]
        [InlineData("Ñabardura", "Nabardura")]
        [InlineData("ÇÑçñ", "CNcn")]
        public void RemoveDiacritics_BasqueText_ReturnsTextWithoutDiacritics(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new BasqueAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }
    }
}