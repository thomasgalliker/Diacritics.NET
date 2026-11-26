using Diacritics.AccentMappings;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class MacedonianAccentsMappingTests
    {
        [Theory]
        [InlineData("Ѓорѓи и Ќерка", "Горги и Керка")]
        [InlineData("ЃЌѓќ", "ГКгк")]
        public void RemoveDiacritics_MacedonianText_ReturnsTextWithoutDiacritics(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new MacedonianAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }
    }
}