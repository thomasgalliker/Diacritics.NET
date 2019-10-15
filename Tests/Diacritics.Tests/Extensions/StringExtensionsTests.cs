namespace Diacritics.Tests.Extensions
{
    using System;

    using Diacritics.Extensions;

    using FluentAssertions;

    using Moq;

    using Xunit;

    public class StringExtensionsTests : IDisposable
    {
        public void Dispose()
        {
            StaticDiacritics.SetDefaultMapper(() => new DefaultDiacriticsMapper());
        }

        [Fact]
        public void ShouldCallRemoveDiacriticsOnCustomMapperWhenCallRemoveDiacritics()
        {
            //Arrange
            const string expectedValue = "it s work";
            const string value = "ÉÖüä$üàè";
            var diacriticsMapperMock = new Mock<IDiacriticsMapper>();
            diacriticsMapperMock.Setup(mapper => mapper.RemoveDiacritics(value))
                                .Returns(expectedValue);
            StaticDiacritics.SetDefaultMapper(() => diacriticsMapperMock.Object);

            // Act
            var actual = value.RemoveDiacritics();

            // Assert
            actual.Should().Be(expectedValue);
        }

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