using Diacritics.AccentMappings;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class LithuanianAccentsMappingTests
    {
        [Theory]
        [InlineData("Ąžuolas, eglė ir šaltinių vanduo", "Azuolas, egle ir saltiniu vanduo")]
        [InlineData("ĄČĘĖĮŠŲŪŽ", "ACEEISUUZ")]
        public void RemoveDiacritics_LithuanianText_ReturnsTextWithoutDiacritics(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new LithuanianAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }
    }
}