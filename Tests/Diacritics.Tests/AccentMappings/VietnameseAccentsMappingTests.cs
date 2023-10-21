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
                    "Ca phe sua da hay con goi don gian la ca phe sua la mot loai thuc uong thong dung o Viet Nam.");

                this.Add(
                    "áàạảãâấầậẩẫăắằặẳẵ",
                    "aaaaaaaaaaaaaaaaa");

                this.Add(
                    "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
                    "AAAAAAAAAAAAAAAAA");

                this.Add(
                    "éèẹẻẽêếềệểễ",
                    "eeeeeeeeeee");

                this.Add(
                    "ÉÈẸẺẼÊẾỀỆỂỄ",
                    "EEEEEEEEEEE");

                this.Add(
                    "óòọỏõôốồộổỗơớờợởỡ",
                    "ooooooooooooooooo");

                this.Add(
                    "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
                    "OOOOOOOOOOOOOOOOO");

                this.Add(
                    "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
                    "OOOOOOOOOOOOOOOOO");

                this.Add(
                    "úùụủũưứừựửữ",
                    "uuuuuuuuuuu");

                this.Add(
                    "ÚÙỤỦŨƯỨỪỰỬỮ",
                    "UUUUUUUUUUU");

                this.Add(
                    "íìịỉĩ",
                    "iiiii");

                this.Add(
                    "ÍÌỊỈĨ",
                    "IIIII");

                this.Add(
                    "đ",
                    "d");

                this.Add(
                    "Đ",
                    "D");

                this.Add(
                    "ýỳỵỷỹ",
                    "yyyyy");

                this.Add(
                    "ÝỲỴỶỸ",
                    "YYYYY");
            }
        }
    }
}