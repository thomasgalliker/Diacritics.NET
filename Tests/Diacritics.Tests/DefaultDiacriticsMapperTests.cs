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

        [Fact]
        public void ShouldMeasurePerformanceOfRemoveDiacritics()
        {
            var performanceTestData = new PerformanceTestData();

            foreach (var testData in performanceTestData)
            {
                // Arrange
                var sourceChar = (char)testData[1];
                var sourceLength = (int)testData[0];
                var source = new string(sourceChar, sourceLength);
                var diacriticsMapper = new DefaultDiacriticsMapper();
                var stopwatch = new Stopwatch();

                // Act
                stopwatch.Start();
                var result = diacriticsMapper.RemoveDiacritics(source);
                stopwatch.Stop();

                // Assert
                this.testOutputHelper.WriteLine($"source = {source.Length}x '{sourceChar}'");
                this.testOutputHelper.WriteLine($"stopwatch.ElapsedMilliseconds = {stopwatch.ElapsedMilliseconds}ms");
                this.testOutputHelper.WriteLine($"stopwatch.ElapsedTicks = {stopwatch.ElapsedTicks}");
                this.testOutputHelper.WriteLine("");
                this.testOutputHelper.WriteLine("----------------------------------------");
                this.testOutputHelper.WriteLine("");

                result.HasDiacritics().Should().BeFalse();
            }
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
                this.Add(1000000, '*');
                this.Add(10000000, '*');
                this.Add(100000000, '*');
#if DEBUG
                this.Add(1000000000, '*');
#endif

                // Diacritics
                this.Add(1, 'é');
                this.Add(10, 'É');
                this.Add(100, 'ä');
                this.Add(1000, 'Ä');
                this.Add(10000, 'é');
                this.Add(100000, 'é');
                this.Add(1000000, 'é');
                this.Add(10000000, 'é');
                this.Add(100000000, 'é');
#if DEBUG
                this.Add(1000000000, 'é');
#endif
            }
        }
    }
}