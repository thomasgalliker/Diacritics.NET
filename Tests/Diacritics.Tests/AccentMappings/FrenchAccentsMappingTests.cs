using Diacritics.AccentMappings;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class FrenchAccentsMappingTests
    {
        [Theory]
        [InlineData("Ça a été un garçon très âgé", "Ca a ete un garcon tres age")]
        [InlineData("Œuvre", "Oeuvre")]
        [InlineData("cœur", "coeur")]
        [InlineData("Æthiopie", "Aethiopie")]
        [InlineData("ex æquo", "ex aequo")]
        public void RemoveDiacritics_FrenchText_ReturnsTextWithoutDiacritics(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new FrenchAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }
    }
}