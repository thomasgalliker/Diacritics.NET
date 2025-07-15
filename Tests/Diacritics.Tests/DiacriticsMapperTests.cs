using System;
using System.Linq;
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
            const string InputText = "ètôile";
            const string ExpectedText = "ètôile";

            // Act
            var output = diacriticsMapper.RemoveDiacritics(InputText);

            // Assert
            output.Should().Be(ExpectedText);
        }

        [Fact]
        public void ShouldRemoveDiacritics_WithSingleMapping()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new FrenchAccentsMapping());
            const string InputText = "Delémont";
            const string ExpectedText = "Delemont";

            // Act
            var output = diacriticsMapper.RemoveDiacritics(InputText);

            // Assert
            output.Should().Be(ExpectedText);
        }

        [Fact]
        public void ShouldNotRemoveDiacritics_IfTheyAreNotPartOfTheMapping()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new FrenchAccentsMapping());
            const string InputText = "ètöile";
            const string ExpectedText = "etöile";

            // Act
            var output = diacriticsMapper.RemoveDiacritics(InputText);

            // Assert
            output.Should().Be(ExpectedText);
        }

        [Fact]
        public void ShouldRemoveDiacritics_WithMultipleMappings()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new FrenchAccentsMapping(), new GermanAccentsMapping());
            const string InputText = "ètöile";
            const string ExpectedText = "etoile";

            // Act
            var output = diacriticsMapper.RemoveDiacritics(InputText);

            // Assert
            output.Should().Be(ExpectedText);
        }

        [Fact]
        public void ShouldRemoveDiacritics_FromUppercaseCharacters()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new FrenchAccentsMapping());
            const string InputText = "Ètoilé";
            const string ExpectedText = "Etoile";

            // Act
            var output = diacriticsMapper.RemoveDiacritics(InputText);

            // Assert
            output.Should().Be(ExpectedText);
        }

        [Fact]
        public void ShouldRemoveDiacritics_CombinedCedilleDiacritics()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new FrenchAccentsMapping());
            const string InputText = "François";
            const string ExpectedText = "Francois";

            // Act
            var output = diacriticsMapper.RemoveDiacritics(InputText);

            // Assert
            output.Should().Be(ExpectedText);
        }

        [Fact]
        public void ShouldRemoveEszett()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new GermanAccentsMapping());
            const string InputText = "Paßstraße";
            const string ExpectedText = "Passstrasse";

            var options = new DiacriticsOptions
            {
                Decompose = true,
            };

            // Act
            var output = diacriticsMapper.RemoveDiacritics(InputText, options);

            // Assert
            output.Should().Be(ExpectedText);
        }

        [Fact]
        public void ShouldRemoveUmlaut_Decomposed()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new FinnishAccentsMapping(), new GermanAccentsMapping());
            const string InputText = "Gefäß";
            const string ExpectedText = "Gefaess";

            var options = new DiacriticsOptions
            {
                Decompose = true,
            };

            // Act
            var output = diacriticsMapper.RemoveDiacritics(InputText, options);

            // Assert
            output.Should().Be(ExpectedText);
        }

        [Fact]
        public void ShouldRemoveFirstCharacter_WithSingleMapping_AndDecomposeFalse()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new FrenchAccentsMapping());
            const string InputText = "épaule";
            const string ExpectedText = "epaule";

            var options = new DiacriticsOptions
            {
                Decompose = false,
            };

            // Act
            var output = diacriticsMapper.RemoveDiacritics(InputText, options);

            // Assert
            output.Should().Be(ExpectedText);
        }

        [Fact]
        public void ShouldRemoveFirstCharacter_WithSingleMapping_AndDecomposeTrue()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new GermanAccentsMapping());
            const string InputText = "Ärzte";
            const string ExpectedText = "Aerzte";

            var options = new DiacriticsOptions
            {
                Decompose = true,
            };

            // Act
            var output = diacriticsMapper.RemoveDiacritics(InputText, options);

            // Assert
            output.Should().Be(ExpectedText);
        }

        [Fact]
        public void ShouldRemoveFirstCharacter_WithMultipleMappings_AndDecomposeFalse()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new FrenchAccentsMapping(), new GermanAccentsMapping());
            const string InputText = "épaule";
            const string ExpectedText = "epaule";

            var options = new DiacriticsOptions
            {
                Decompose = false,
            };

            // Act
            var output = diacriticsMapper.RemoveDiacritics(InputText, options);

            // Assert
            output.Should().Be(ExpectedText);
        }

        [Fact]
        public void ShouldRemoveFirstCharacter_WithMultipleMappings_AndDecomposeTrue()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new FrenchAccentsMapping(), new GermanAccentsMapping());
            const string InputText = "épaule";
            const string ExpectedText = "epaule";

            var options = new DiacriticsOptions
            {
                Decompose = true,
            };

            // Act
            var output = diacriticsMapper.RemoveDiacritics(InputText, options);

            // Assert
            output.Should().Be(ExpectedText);
        }
        #endregion

        #region HasDiacritics

        [Fact]
        public void ShouldReturnFalseIfHasNoMappings()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper();
            const string InputText = "ètôile";

            // Act
            var output = diacriticsMapper.HasDiacritics(InputText);

            // Assert
            output.Should().BeFalse();
        }

        [Fact]
        public void ShouldReturnFalseIfHasNoDiacritics()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new FrenchAccentsMapping());
            const string InputText = "etoile";

            // Act
            var output = diacriticsMapper.HasDiacritics(InputText);

            // Assert
            output.Should().BeFalse();
        }

        [Fact]
        public void ShouldReturnTrueIfHasDiacritics()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new FrenchAccentsMapping());
            const string InputText = "ètôile";

            // Act
            var output = diacriticsMapper.HasDiacritics(InputText);

            // Assert
            output.Should().BeTrue();
        }

        #endregion
    }
}