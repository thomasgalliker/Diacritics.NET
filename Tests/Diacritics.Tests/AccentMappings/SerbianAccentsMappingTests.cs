using Diacritics.AccentMappings;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class SerbianAccentsMappingTests
    {
        [Theory]
        [InlineData("Čačak, Šabac, Žabalj i Ćuprija", "Cacak, Sabac, Zabalj i Cuprija")]
        public void RemoveDiacritics_SerbianText_ReturnsTextWithoutDiacritics(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new SerbianAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }
    }
}