using FluentAssertions;
using Xunit;

namespace Diacritics.Tests
{
    public class MappingReplacementTests
    {
        [Fact]
        public void ShouldBeEqual()
        {
            // Arrange
            var mappingReplacement1 = new MappingReplacement("a", null, null);
            var mappingReplacement2 = new MappingReplacement("a", null, null);

            // Act
            var equal = mappingReplacement1 == mappingReplacement2;

            // Assert
            equal.Should().BeTrue();
        }

        [Fact]
        public void ShouldNotBeEqual()
        {
            // Arrange
            var mappingReplacement1 = new MappingReplacement("a", null, null);
            var mappingReplacement2 = new MappingReplacement("A", null, null);

            // Act
            var equal = mappingReplacement1 == mappingReplacement2;

            // Assert
            equal.Should().BeFalse();
        }
    }
}