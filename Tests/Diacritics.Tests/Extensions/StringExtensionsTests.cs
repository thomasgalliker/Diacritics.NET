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
            output.Should().Be(expectedOutput.Item2);
            hasDiacritics.Should().Be(expectedOutput.Item1);
        }

        public class DiacriticsTestData : TheoryData<string, (bool, string)>
        {
            public DiacriticsTestData()
            {
                // Null, empty, whitespace
                this.Add(null, (false, null));
                this.Add("", (false, ""));
                this.Add(" ", (false, " "));

                // Lower case
                this.Add("x", (false, "x"));

                // Upper case
                this.Add("X", (false, "X"));

                // Mixed with special characters
                this.Add("ÉÖüä$üàè", (true, "EOua$uae"));

                // Random test words
                this.Add("pingüino", (true, "pinguino"));
                this.Add("étoile", (true, "etoile"));
                this.Add("İngiltere", (true, "Ingiltere"));
            }
        }
    }
}
