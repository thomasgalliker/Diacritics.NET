using Diacritics.Extensions;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests.Extensions
{
    public class StringExtensionsTests
    {
        [Theory]
        [ClassData(typeof(DiacriticsTestData))]
        public void ShouldRemoveDiacritics(string input, (bool, string) expectedOutput)
        {
            // Act
            var hasDiacritics = input.HasDiacritics();
            var output = input.RemoveDiacritics();

            // Assert
            hasDiacritics.Should().Be(expectedOutput.Item1);
            output.Should().Be(expectedOutput.Item2);
        }

        public class DiacriticsTestData : TheoryData<string, (bool, string)>
        {
            public DiacriticsTestData()
            {
                this.Add("ÉÖüä$üàè", (true, "EOua$uae"));
                this.Add("pingüino", (true, "pinguino"));
                this.Add("étoile", (true, "etoile"));
            }
        }
    }
}
