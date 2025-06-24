using System.Text;
using System.Threading;
using Diacritics.Internals;
using FluentAssertions;
using Xunit;

namespace Diacritics.Tests.Internals
{
    public class StringBuilderCacheTests
    {
        [Fact]
        public void Acquire_ShouldReturnNewInstance_WhenCacheIsEmpty()
        {
            // Act
            var stringBuilder = StringBuilderCache.Acquire();

            // Assert
            stringBuilder.Should().NotBeNull();
            stringBuilder.Length.Should().Be(0);
        }

        [Fact]
        public void Acquire_ShouldNotReturnTheSameInstance()
        {
            // Act
            var stringBuilder1 = StringBuilderCache.Acquire();
            var stringBuilder2 = StringBuilderCache.Acquire();

            // Assert
            stringBuilder1.Should().NotBe(stringBuilder2);
        }

        [Fact]
        public void Acquire_ShouldReturnTheSameInstance()
        {
            // Arrange
            var stringBuilder1 = StringBuilderCache.Acquire();
            StringBuilderCache.Release(stringBuilder1);

            // Act
            var stringBuilder2 = StringBuilderCache.Acquire();

            // Assert
            stringBuilder2.Should().BeSameAs(stringBuilder1);
        }

        [Fact]
        public void Acquire_ShouldReturnExistingStringBuilder()
        {
            // Arrange
            const string expectedString1 = "string 1";
            const string expectedString2 = "string 2";

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
        public void GetStringAndRelease_ShouldReturnString_AndStoreInstanceInCache()
        {
            // Arrange
            var stringBuilder1 = StringBuilderCache.Acquire();
            stringBuilder1.Append("test");

            // Act
            var result = StringBuilderCache.GetStringAndRelease(stringBuilder1);

            // Assert
            result.Should().Be("test");

            // Next Acquire should reuse the same instance
            var stringBuilder2 = StringBuilderCache.Acquire();
            stringBuilder2.Should().BeSameAs(stringBuilder1);
            stringBuilder2.Length.Should().Be(0);
        }

        [Fact]
        public void Acquire_ShouldNotReuseBuilder_UntilReleased()
        {
            // Arrange
            var stringBuilder1 = StringBuilderCache.Acquire();

            // Act
            var stringBuilder2 = StringBuilderCache.Acquire();

            // Assert
            stringBuilder1.Should().NotBeSameAs(stringBuilder2);
        }

        [Fact]
        public void Cache_ShouldBeThreadLocal()
        {
            // Arrange
            var stringBuilder1 = StringBuilderCache.Acquire(); // Acquire and release in main thread
            stringBuilder1.Append("main");
            StringBuilderCache.GetStringAndRelease(stringBuilder1);

            StringBuilder stringBuilder2 = null;

            // Act
            var thread = new Thread(() =>
            {
                var other = StringBuilderCache.Acquire();
                stringBuilder2 = other;
            });

            thread.Start();
            thread.Join();

            // Arrange
            stringBuilder1.Should().NotBeNull();
            stringBuilder2.Should().NotBeNull();
            stringBuilder2.Should().NotBeSameAs(stringBuilder1);
        }
    }
}