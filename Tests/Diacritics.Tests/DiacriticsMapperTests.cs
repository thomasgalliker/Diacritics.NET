using Diacritics.AccentMappings;

using FluentAssertions;

using Xunit;

namespace Diacritics.Tests
{
    public class DiacriticsMapperTests
    {
        #region RemoveDiacritics

        [Fact]
        public void ShouldNotRemoveDiacriticsIfNoMappingsAvailable()
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
        public void ShouldRemoveDiacriticsFromSingleMapping()
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
        public void ShouldNotRemoveDiacriticsIfTheyAreNotPartOfTheMapping()
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
        public void ShouldRemoveDiacriticsFromMultipleMappings()
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
        public void ShouldRemoveDiacriticsFromUppercaseCharacters()
        {
            // Arrange
            IDiacriticsMapper diacriticsMapper = new DiacriticsMapper(new FrenchAccentsMapping());
            const string InputText = "ÈtoilE";
            const string ExpectedText = "EtoilE";

            // Act
            var output = diacriticsMapper.RemoveDiacritics(InputText);

            // Assert
            output.Should().Be(ExpectedText);
        }

        [Fact]
        public void ShouldRemoveCombinedCedilleDiacritics()
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

            // Act
            var output = diacriticsMapper.RemoveDiacritics(InputText);

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