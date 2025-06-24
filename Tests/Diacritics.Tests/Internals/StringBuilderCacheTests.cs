using System.Text;
using System.Threading;
using Diacritics.Internals;
using FluentAssertions;
using Moq;
using Xunit;

namespace Diacritics.Tests.Internals
{
    public class StringBuilderCacheTests
    {
        [Fact]
        public void Acquire_ShouldReturnExistingStringBuilder()
        {
            // Arrange
            const string expectedString1  = "string 1";
            const string expectedString2 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";

            var stringBuilder1 = StringBuilderCache.Acquire(100);
            stringBuilder1.Append(expectedString1);
            var getString1 = StringBuilderCache.GetStringAndRelease(stringBuilder1);
            var getString2 = StringBuilderCache.GetStringAndRelease(stringBuilder1);

            // Act
            var stringBuilder2 = StringBuilderCache.Acquire();
            stringBuilder2.Append(expectedString2);
            var getString3 = StringBuilderCache.GetStringAndRelease(stringBuilder2);

            // Assert
            getString1.Should().Be(expectedString1);
            getString2.Should().Be(expectedString1);
            getString3.Should().Be(expectedString2);
        }

        [Fact]
        public void Acquire_ShouldNotReturnTheSameInstance()
        {
            // Act
            var builderOne = StringBuilderCache.Acquire();
            var builderTwo = StringBuilderCache.Acquire();

            // Assert
            builderOne.Should().NotBe(builderTwo);
        }

        [Fact]
        public void Acquire_ShouldReturnTheSameInstance()
        {
            // Arrange
            var builderOne = StringBuilderCache.Acquire();

            StringBuilderCache.Release(builderOne);

            // Act
            var builderTwo = StringBuilderCache.Acquire();

            // Assert
            builderTwo.Should().BeSameAs(builderOne);
        }

        [Fact]
        public void Acquire_ShouldReturnNewInstance_WhenCacheIsEmpty()
        {
            var builder = StringBuilderCache.Acquire();

            Assert.NotNull(builder);
            Assert.Equal(0, builder.Length);
        }

        [Fact]
        public void GetStringAndRelease_ShouldReturnString_AndStoreInstanceInCache()
        {
            var builder = StringBuilderCache.Acquire();
            builder.Append("test");

            var result = StringBuilderCache.GetStringAndRelease(builder);

            Assert.Equal("test", result);

            // Next Acquire should reuse the same instance
            var reused = StringBuilderCache.Acquire();
            Assert.Same(builder, reused);
            Assert.Equal(0, reused.Length);
        }

        [Fact]
        public void Acquire_ShouldNotReuseBuilder_UntilReleased()
        {
            var first = StringBuilderCache.Acquire();

            // Not released, should not be reused
            var second = StringBuilderCache.Acquire();

            Assert.NotSame(first, second);
        }

        [Fact]
        public void Cache_ShouldBeThreadLocal()
        {
            // Arrange
            StringBuilder mainThreadBuilder;
            StringBuilder otherThreadBuilder = null;

            // Acquire and release in main thread
            var builder = StringBuilderCache.Acquire();
            builder.Append("main");
            StringBuilderCache.GetStringAndRelease(builder);
            mainThreadBuilder = builder;

            // Start new thread and acquire
            var thread = new Thread(() =>
            {
                var other = StringBuilderCache.Acquire();
                otherThreadBuilder = other;
            });

            thread.Start();
            thread.Join();

            // Arrange
            mainThreadBuilder.Should().NotBeNull();
            otherThreadBuilder.Should().NotBeNull();
            otherThreadBuilder.Should().NotBeSameAs(mainThreadBuilder);
        }
    }
}