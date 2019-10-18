using System;
using FluentAssertions;
using Moq;
using Xunit;

namespace Diacritics.Tests
{
    public class StaticDiacriticsTests : IDisposable
    {
        [Fact]
        public void ShouldCanReplaceDefaultImplementationOfCurrentMapper()
        {
            // Arrange
            var diacriticsMapperMock = new Mock<IDiacriticsMapper>();
           
            // Act
            StaticDiacritics.SetDefaultMapper(() => diacriticsMapperMock.Object);
            var diacriticsMapper = StaticDiacritics.Current;

            // Assert
            diacriticsMapper.Should().BeSameAs(diacriticsMapperMock.Object);
        }

        [Fact]
        public void ShouldReturnDefaultDiacriticsMapperWhenCallCurrent()
        {
            // Act
            var diacriticsMapper = StaticDiacritics.Current;

            // Assert
            diacriticsMapper.Should().BeOfType<DefaultDiacriticsMapper>();
        }

        public void Dispose()
        {
            StaticDiacritics.SetDefaultMapper(() => new DefaultDiacriticsMapper());
        }
    }
}