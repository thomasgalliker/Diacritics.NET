using Diacritics.AccentMappings;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class OtherAccentsMappingTests
    {
        [Theory]
        [ClassData(typeof(AccentMappingTestdata))]
        public void ShouldRemoveDiacritics(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new OtherAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }

        internal class AccentMappingTestdata : TheoryData<string, string>
        {
            public AccentMappingTestdata()
            {
                // G with caron (U+01E6, U+01E7)
                this.Add("Ǧ", "G");
                this.Add("ǧ", "g");
            }
        }
    }
}
