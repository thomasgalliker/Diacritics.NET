using System;
using FluentAssertions;
using Moq;
using Xunit;

namespace Diacritics.Tests
{
    [Collection("StaticDiacritics")]
    public class StaticDiacriticsTests : IDisposable
    {
        [Fact]
        public void ShouldCanReplaceDefaultImplementationOfCurrentMapper()
        {
            // Arrange
            var diacriticsMapperMock = new Mock<IDiacriticsMapper>();

            // Act
            DiacriticsMapper.SetDefaultMapper(() => diacriticsMapperMock.Object);
            var diacriticsMapper = DiacriticsMapper.Current;

            // Assert
            diacriticsMapper.Should().BeSameAs(diacriticsMapperMock.Object);
        }

        [Fact]
        public void ShouldReturnDefaultDiacriticsMapperWhenCallCurrent()
        {
            // Act
            var diacriticsMapper = DiacriticsMapper.Current;

            // Assert
            diacriticsMapper.Should().BeOfType<DefaultDiacriticsMapper>();
        }

        public void Dispose()
        {
            DiacriticsMapper.SetDefaultMapper(() => new DefaultDiacriticsMapper());
        }
    }
}