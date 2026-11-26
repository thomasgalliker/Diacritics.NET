using Diacritics.AccentMappings;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class KyrgyzAccentsMappingTests
    {
        [Theory]
        [InlineData("ЁЙёй", "ЕИеи")]
        public void RemoveDiacritics_KyrgyzText_ReturnsTextWithoutDiacritics(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new KyrgyzAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }
    }
}