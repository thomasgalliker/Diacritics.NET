using System.Diagnostics;
using System.Linq;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Diacritics.Tests
{
    public class DefaultDiacriticsMapperTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        public DefaultDiacriticsMapperTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void ShouldReturnAllDefaultDiacritics()
        {
            // Arrange
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var defaultDiacriticsMapper = new DefaultDiacriticsMapper();
            
            // Act
            var defaultDiacriticsMapping = defaultDiacriticsMapper.ToList();
            stopwatch.Stop();

            // Assert
            defaultDiacriticsMapping.Should().HaveCount(103);
            this.testOutputHelper.WriteLine("stopwatch.ElapsedMilliseconds = {0}ms", stopwatch.ElapsedMilliseconds);
            stopwatch.ElapsedMilliseconds.Should().BeLessThan(50);
        }
    }
}
