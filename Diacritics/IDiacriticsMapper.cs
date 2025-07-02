using System.Collections.Generic;
using Diacritics.AccentMappings;

namespace Diacritics
{
    public interface IDiacriticsMapper : IEnumerable<KeyValuePair<char, MappingReplacement>>
    {
#if NET7_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        /// <summary>
        /// Gets the singleton instance of <see cref="IDiacriticsMapper"/>.
        /// </summary>
        public static IDiacriticsMapper Current { get; } = DiacriticsMapper.Current;
#endif

        /// <summary>
        /// Removes any diacritical characters from <paramref name="source"/>.
        /// </summary>
        /// <param name="source">The source string.</param>
        string RemoveDiacritics(string source);

        /// <summary>
        /// Removes any diacritical characters from <paramref name="source"/>.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <param name="options">The options.</param>
        string RemoveDiacritics(string source, DiacriticsOptions options);

        /// <summary>
        /// Removes any diacritical characters from <paramref name="source"/> using custom accent mappings.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <param name="mappings">The accent mapping to be used to replace diacritical characters.</param>
        string RemoveDiacritics(string source, IAccentMapping[] mappings);

        /// <summary>
        /// Removes any diacritical characters from <paramref name="source"/> using custom accent mappings.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <param name="mappings">The accent mapping to be used to replace diacritical characters.</param>
        /// <param name="options">The options.</param>
        string RemoveDiacritics(string source, IAccentMapping[] mappings, DiacriticsOptions options);

        /// <summary>
        /// Checks if the given <paramref name="source"/> string contains any diacritical characters.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <returns><c>true</c> if the source string contains any diacritical characters; otherwise, <c>false</c>.</returns>
        bool HasDiacritics(string source);

        /// <summary>
        /// Checks if the given <paramref name="source"/> string contains any diacritical characters.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <param name="options">The options.</param>
        /// <returns><c>true</c> if the source string contains any diacritical characters; otherwise, <c>false</c>.</returns>
        bool HasDiacritics(string source, DiacriticsOptions options);
    }
}