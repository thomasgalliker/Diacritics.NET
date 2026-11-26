using Diacritics.AccentMappings;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class SlovenianAccentsMappingTests
    {
        [Theory]
        [InlineData("Čevapčiči in žganci, šunka", "Cevapcici in zganci, sunka")]
        public void RemoveDiacritics_SlovenianText_ReturnsTextWithoutDiacritics(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new SlovenianAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }
    }
}