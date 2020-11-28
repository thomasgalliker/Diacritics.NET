using Diacritics.AccentMappings;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class VietnameseAccentsMappingTests
    {
        [Theory]
        [ClassData(typeof(AccentMappingTestdata))]
        public void ShouldRemoveDiacritics(string input, string expectedOutput)
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
                this.Add(
                    "Cà phê sữa đá hay còn gọi đơn giản là cà phê sữa là một loại thức uống thông dụng ở Việt Nam.", 
                    "Ca phe sua đa hay con goi đon gian la ca phe sua la mot loai thuc uong thong dung o Viet Nam.");
            }
        }
    }
}