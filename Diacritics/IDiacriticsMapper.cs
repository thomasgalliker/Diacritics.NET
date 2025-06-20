using System.Collections.Generic;

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

        string RemoveDiacritics(string source, DiacriticsOptions options = null);

        bool HasDiacritics(string source, DiacriticsOptions options = null);
    }
}