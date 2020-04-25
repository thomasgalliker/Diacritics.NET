using Diacritics.AccentMappings;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class VietnameseAccentsMappingTests
    {
        [Theory]
        [ClassData(typeof(AccentMappingTestdata))]
        public void ShouldRemoveDiacriticsForAccentsMapping(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new VietnameseAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            expectedOutput.Should().Be(output);
        }

        internal class AccentMappingTestdata : TheoryData<string, string>
        {
            public AccentMappingTestdata()
            {
                this.Add("Cà phê sữa đá hay còn gọi đơn giản là cà phê sữa là một loại thức uống thông dụng ở Việt Nam.", "Cà phê sữa đá hay còn gọi đơn giản là cà phê sữa là một loại thức uống thông dụng o Việt Nam.");
            }
        }
    }
}