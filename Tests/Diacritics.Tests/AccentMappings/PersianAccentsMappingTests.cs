using Diacritics.AccentMappings;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class PersianAccentsMappingTests
    {
        [Theory]
        [InlineData("آب", "اب")]
        [InlineData("آأؤئ", "ااوي")]
        public void RemoveDiacritics_PersianText_ReturnsTextWithoutDiacritics(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new PersianAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }
    }
}