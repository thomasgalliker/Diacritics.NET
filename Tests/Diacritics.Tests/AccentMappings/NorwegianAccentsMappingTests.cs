using Diacritics.AccentMappings;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class NorwegianAccentsMappingTests
    {
        [Theory]
        [InlineData("Blåbærsyltetøy på brødskiva", "Blabaersyltetoy pa brodskiva")]
        [InlineData("ÀÉÓÒÔÅÆØ", "AEOOOAAeO")]
        public void RemoveDiacritics_NorwegianText_ReturnsTextWithoutDiacritics(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new NorwegianAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }
    }
}