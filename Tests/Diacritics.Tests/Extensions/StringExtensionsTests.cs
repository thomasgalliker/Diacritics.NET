using Diacritics.Extensions;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests.Extensions
{
    public class StringExtensionsTests
    {
        [Fact]
        public void ShouldTestHasDiacriticsExtensionMethod()
        {
            // Arrange
            const string InputString = "àdslkfjlskf";

            // Act
            bool hasDiacritics = InputString.HasDiacritics();

            // Assert
            hasDiacritics.Should().BeTrue();
        }

        [Fact]
        public void ShouldTestRemoveDiacriticsExtensionMethod()
        {
            // Arrange
            const string InputString = "àdslkfjlskf";

            // Act
            string removeDiacritics = InputString.RemoveDiacritics();

            // Assert
            removeDiacritics.Should().Be("adslkfjlskf");
        }
    }
}
