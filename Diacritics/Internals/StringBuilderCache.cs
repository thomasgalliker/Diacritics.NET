using System;
using System.Diagnostics;
using System.Text;

namespace Diacritics.Internals
{
    /// <summary>
    /// Provides a cached reusable instance of <see cref="StringBuilder"/> per thread
    /// it is an optimization that reduces the number of instances constructed and collected by the GC.
    /// <remarks>
    /// <para>A StringBuilder instance is cached in <c>Thread Local Storage</c> and so there is one per thread.</para>
    /// </remarks>
    /// </summary>
    internal static class StringBuilderCache
    {
        private const int MaxSize = 256;
        private const int DefaultCapacity = 16;

        [ThreadStatic]
        private static StringBuilder CachedInstance;

        /// <summary>
        /// Acquires a cached instance of <see cref="StringBuilder"/> if one exists otherwise a new instance.
        /// </summary>
        /// <returns>An instance of <see cref="StringBuilder"/>.</returns>
        // [DebuggerStepThrough]
        public static StringBuilder Acquire(int capacity = DefaultCapacity)
        {
            if (capacity <= MaxSize)
            {
                var stringBuilder = CachedInstance;

                if (stringBuilder != null && capacity <= stringBuilder.Capacity)
                {
                    CachedInstance = null;
                    stringBuilder.Clear();
                    return stringBuilder;
                }
            }

            return new StringBuilder(capacity);
        }

        /// <summary>
        /// Gets the string representation of the <paramref name="stringBuilder"/> and releases it to the cache.
        /// </summary>
        /// <param name="stringBuilder">The <see cref="StringBuilder"/> instance.</param>
        /// <returns>The string representation of the <paramref name="stringBuilder"/></returns>
        // [DebuggerStepThrough]
        public static string GetStringAndRelease(StringBuilder stringBuilder)
        {
            var str = stringBuilder.ToString();
            Release(stringBuilder);
            return str;
        }

        // [DebuggerStepThrough]
        public static void Release(StringBuilder stringBuilder)
        {
            if (stringBuilder.Capacity <= MaxSize)
            {
                CachedInstance = stringBuilder;
            }
        }
    }
}