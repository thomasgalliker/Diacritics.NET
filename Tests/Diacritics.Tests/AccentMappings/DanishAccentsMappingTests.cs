using Diacritics.AccentMappings;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class DanishAccentsMappingTests
    {
        [Theory]
        [InlineData("Æbleskiver på Øresund", "Aebleskiver pa Oresund")]
        [InlineData("ÅÆØåæø", "AAeOaaeo")]
        public void RemoveDiacritics_DanishText_ReturnsTextWithoutDiacritics(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new DanishAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }
    }
}