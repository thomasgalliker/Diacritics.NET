using System.Diagnostics;
using System.Linq;
using Diacritics.Extensions;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Diacritics.Tests
{
    [Collection("StaticDiacritics")]
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
            defaultDiacriticsMapping.Should().NotBeEmpty();
            this.testOutputHelper.WriteLine($"stopwatch.ElapsedMilliseconds = {stopwatch.ElapsedMilliseconds}ms");
            this.testOutputHelper.WriteLine($"defaultDiacriticsMapping.Count = {defaultDiacriticsMapping.Count}");
        }

        [Theory]
        [ClassData(typeof(PerformanceTestData))]
        public void ShouldMeasurePerformanceOfRemoveDiacritics(int count, char c)
        {
            // Arrange
            var input = new string(c, count);
            var defaultDiacriticsMapper = new DefaultDiacriticsMapper();
            var stopwatch = new Stopwatch();

            // Act
            stopwatch.Start();
            var defaultDiacriticsMapping = defaultDiacriticsMapper.RemoveDiacritics(input);
            stopwatch.Stop();

            // Assert
            this.testOutputHelper.WriteLine($"input.Length = {input.Length}");
            this.testOutputHelper.WriteLine($"stopwatch.ElapsedMilliseconds = {stopwatch.ElapsedMilliseconds}ms");
            this.testOutputHelper.WriteLine($"stopwatch.ElapsedTicks = {stopwatch.ElapsedTicks}");

            defaultDiacriticsMapping.HasDiacritics().Should().BeFalse();
        }

        public class PerformanceTestData : TheoryData<int, char>
        {
            public PerformanceTestData()
            {
                // Non-diacritics
                this.Add(1, '*');
                this.Add(10, '*');
                this.Add(100, '*');
                this.Add(1000, '*');
                this.Add(10000, '*');
                this.Add(100000, '*');

                // Diacritics
                this.Add(1, 'é');
                this.Add(10, 'É');
                this.Add(100, 'ä');
                this.Add(1000, 'Ä');
                this.Add(10000, 'é');
                this.Add(100000, 'é');
            }
        }
    }
}