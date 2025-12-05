using Diacritics.AccentMappings;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class DiacriticsMapperTests
    {
        #region RemoveDiacritics

        [Fact]
        public void ShouldNotRemoveDiacritics_IfNoMappingsAvailable()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper();
            const string inputText = "ètôile";
            const string expectedText = "ètôile";

            // Act
            var output = diacriticsMapper.RemoveDiacritics(inputText);

            // Assert
            output.Should().Be(expectedText);
        }

        [Fact]
        public void ShouldRemoveDiacritics_WithSingleMapping()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new FrenchAccentsMapping());
            const string inputText = "Delémont";
            const string expectedText = "Delemont";

            // Act
            var output = diacriticsMapper.RemoveDiacritics(inputText);

            // Assert
            output.Should().Be(expectedText);
        }

        [Fact]
        public void ShouldNotRemoveDiacritics_IfTheyAreNotPartOfTheMapping()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new FrenchAccentsMapping());
            const string inputText = "ètöile";
            const string expectedText = "etöile";

            // Act
            var output = diacriticsMapper.RemoveDiacritics(inputText);

            // Assert
            output.Should().Be(expectedText);
        }

        [Fact]
        public void ShouldRemoveDiacritics_WithMultipleMappings()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new FrenchAccentsMapping(), new GermanAccentsMapping());
            const string inputText = "ètöile";
            const string expectedText = "etoile";

            // Act
            var output = diacriticsMapper.RemoveDiacritics(inputText);

            // Assert
            output.Should().Be(expectedText);
        }

        [Fact]
        public void ShouldRemoveDiacritics_FromUppercaseCharacters()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new FrenchAccentsMapping());
            const string inputText = "Ètoilé";
            const string expectedText = "Etoile";

            // Act
            var output = diacriticsMapper.RemoveDiacritics(inputText);

            // Assert
            output.Should().Be(expectedText);
        }

        [Fact]
        public void ShouldRemoveDiacritics_CombinedCedilleDiacritics()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new FrenchAccentsMapping());
            const string inputText = "François";
            const string expectedText = "Francois";

            // Act
            var output = diacriticsMapper.RemoveDiacritics(inputText);

            // Assert
            output.Should().Be(expectedText);
        }

        [Fact]
        public void ShouldRemoveEszett()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new GermanAccentsMapping());
            const string inputText = "Paßstraße";
            const string expectedText = "Passstrasse";

            var options = new DiacriticsOptions
            {
                Decompose = true,
            };

            // Act
            var output = diacriticsMapper.RemoveDiacritics(inputText, options);

            // Assert
            output.Should().Be(expectedText);
        }

        [Fact]
        public void ShouldRemoveUmlaut_Decomposed()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new FinnishAccentsMapping(), new GermanAccentsMapping());
            const string inputText = "Gefäß";
            const string expectedText = "Gefaess";

            var options = new DiacriticsOptions
            {
                Decompose = true,
            };

            // Act
            var output = diacriticsMapper.RemoveDiacritics(inputText, options);

            // Assert
            output.Should().Be(expectedText);
        }

        [Fact]
        public void ShouldRemoveFirstCharacter_WithSingleMapping_AndDecomposeFalse()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new FrenchAccentsMapping());
            const string inputText = "épaule";
            const string expectedText = "epaule";

            var options = new DiacriticsOptions
            {
                Decompose = false,
            };

            // Act
            var output = diacriticsMapper.RemoveDiacritics(inputText, options);

            // Assert
            output.Should().Be(expectedText);
        }

        [Fact]
        public void ShouldRemoveFirstCharacter_WithSingleMapping_AndDecomposeTrue()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new GermanAccentsMapping());
            const string inputText = "Ärzte";
            const string expectedText = "Aerzte";

            var options = new DiacriticsOptions
            {
                Decompose = true,
            };

            // Act
            var output = diacriticsMapper.RemoveDiacritics(inputText, options);

            // Assert
            output.Should().Be(expectedText);
        }

        [Fact]
        public void ShouldRemoveFirstCharacter_WithMultipleMappings_AndDecomposeFalse()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new FrenchAccentsMapping(), new GermanAccentsMapping());
            const string inputText = "épaule";
            const string expectedText = "epaule";

            var options = new DiacriticsOptions
            {
                Decompose = false,
            };

            // Act
            var output = diacriticsMapper.RemoveDiacritics(inputText, options);

            // Assert
            output.Should().Be(expectedText);
        }

        [Fact]
        public void ShouldRemoveFirstCharacter_WithMultipleMappings_AndDecomposeTrue()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new FrenchAccentsMapping(), new GermanAccentsMapping());
            const string inputText = "épaule";
            const string expectedText = "epaule";

            var options = new DiacriticsOptions
            {
                Decompose = true,
            };

            // Act
            var output = diacriticsMapper.RemoveDiacritics(inputText, options);

            // Assert
            output.Should().Be(expectedText);
        }
        #endregion

        #region HasDiacritics

        [Fact]
        public void ShouldReturnFalseIfHasNoMappings()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper();
            const string inputText = "ètôile";

            // Act
            var output = diacriticsMapper.HasDiacritics(inputText);

            // Assert
            output.Should().BeFalse();
        }

        [Fact]
        public void ShouldReturnFalseIfHasNoDiacritics()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new FrenchAccentsMapping());
            const string inputText = "etoile";

            // Act
            var output = diacriticsMapper.HasDiacritics(inputText);

            // Assert
            output.Should().BeFalse();
        }

        [Fact]
        public void ShouldReturnTrueIfHasDiacritics()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new FrenchAccentsMapping());
            const string inputText = "ètôile";

            // Act
            var output = diacriticsMapper.HasDiacritics(inputText);

            // Assert
            output.Should().BeTrue();
        }

        #endregion
    }
}