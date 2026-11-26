using Diacritics.AccentMappings;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class KazakhAccentsMappingTests
    {
        [Theory]
        [InlineData("ЁЙёй", "ЕИеи")]
        public void RemoveDiacritics_KazakhText_ReturnsTextWithoutDiacritics(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new KazakhAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }
    }
}