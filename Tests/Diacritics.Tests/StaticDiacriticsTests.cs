namespace Diacritics.Tests
{
    using System;

    using FluentAssertions;

    using Moq;

    using Xunit;

    public class StaticDiacriticsTests : IDisposable
    {
        public void Dispose()
        {
            StaticDiacritics.SetDefaultMapper(() => new DefaultDiacriticsMapper());
        }

        [Fact]
        public void ShouldCanReplaceDefaultImplementationOfCurrentMapper()
        {
            var diacriticsMapperMock = new Mock<IDiacriticsMapper>();
            StaticDiacritics.SetDefaultMapper(() => diacriticsMapperMock.Object);
            var diacriticsMapper = StaticDiacritics.Current;

            diacriticsMapper.Should().BeSameAs(diacriticsMapperMock.Object);
        }

        [Fact]
        public void ShouldReturnDefaultDiacriticsMapperWhenCallCurrent()
        {
            var diacriticsMapper = StaticDiacritics.Current;

            diacriticsMapper.Should().BeOfType<DefaultDiacriticsMapper>();
        }
    }
}