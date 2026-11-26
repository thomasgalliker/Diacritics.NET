using Diacritics.AccentMappings;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class TurkishAccentsMappingTests
    {
        [Theory]
        [ClassData(typeof(AccentMappingTestdata))]
        public void ShouldRemoveDiacritics(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new TurkishAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }

        [Theory]
        [InlineData("Ğ", "G")] // U+011E Latin capital letter G with breve
        [InlineData("ğ", "g")] // U+011F Latin small letter G with breve
        [InlineData("Ǧ", "G")] // U+01E6 Latin capital letter G with caron
        [InlineData("ǧ", "g")] // U+01E7 Latin small letter G with caron
        public void RemoveDiacritics_DefaultMapperWithGVariants_ReturnsPlainG(string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DefaultDiacriticsMapper();

            // Act
            var output = mapper.RemoveDiacritics(input);

            // Assert
            output.Should().Be(expectedOutput);
        }

        internal class AccentMappingTestdata : TheoryData<string, string>
        {
            public AccentMappingTestdata()
            {
                this.Add(
                    "Şişli'de güzel bir ağaç gördüğümü İzmir'deki ılık havada düşündüm.",
                    "Sisli'de guzel bir agac gordugumu Izmir'deki ilik havada dusundum.");

                this.Add("ÇĞİÖŞÜÂÎÛ", "CGIOSUAIU");
                this.Add("çğıöşüâîû", "cgiosuaiu");

                // G with breve (U+011E, U+011F)
                this.Add("Ğ", "G");
                this.Add("ğ", "g");

                // G with caron (U+01E6, U+01E7)
                this.Add("Ǧ", "G");
                this.Add("ǧ", "g");
                this.Add("Doǧu", "Dogu");
            }
        }
    }
}
