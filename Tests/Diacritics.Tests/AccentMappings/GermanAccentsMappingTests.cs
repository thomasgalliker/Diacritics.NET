using Diacritics.AccentMappings;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class GermanAccentsMappingTests
    {
        [Theory]
        [ClassData(typeof(AccentMappingTestdata))]
        public void ShouldRemoveDiacritics(DiacriticsOptions options, string input, string expectedOutput)
        {
            // Arrange
            var mapper = new DiacriticsMapper(new GermanAccentsMapping());

            // Act
            var output = mapper.RemoveDiacritics(input, options);

            // Assert
            expectedOutput.Should().Be(output);
        }

        internal class AccentMappingTestdata : TheoryData<DiacriticsOptions, string, string>
        {
            public AccentMappingTestdata()
            {
                // Without decomposition
                {
                    var options = new DiacriticsOptions { Decompose = false };
                    this.Add(options,
                        "Ärger",
                        "Arger");
                    this.Add(options,
                        "glücklich",
                        "glucklich");
                    this.Add(options,
                        "Spaß",
                        "Spaß");
                }

                // With decomposition
                {
                    var options = new DiacriticsOptions { Decompose = true };
                    this.Add(options,
                        "Ärger",
                        "Aerger");
                    this.Add(options,
                        "glücklich",
                        "gluecklich");
                    this.Add(options,
                        "Spaß",
                        "Spass");
                }
            }
        }
    }
}