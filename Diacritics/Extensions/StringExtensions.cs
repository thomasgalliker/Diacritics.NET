
using Diacritics.AccentMappings;

namespace Diacritics.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IDiacriticsMapper.RemoveDiacritics(string)"/>
        public static string RemoveDiacritics(this string source)
        {
            return DiacriticsMapper.Current.RemoveDiacritics(source);
        }

        /// <inheritdoc cref="IDiacriticsMapper.RemoveDiacritics(string, DiacriticsOptions)"/>
        public static string RemoveDiacritics(this string source, DiacriticsOptions options)
        {
            return DiacriticsMapper.Current.RemoveDiacritics(source, options);
        }

        /// <inheritdoc cref="IDiacriticsMapper.RemoveDiacritics(string, IAccentMapping[])"/>
        public static string RemoveDiacritics(this string source, params IAccentMapping[] mappings)
        {
            return DiacriticsMapper.Current.RemoveDiacritics(source, mappings);
        }

        /// <inheritdoc cref="IDiacriticsMapper.RemoveDiacritics(string, IAccentMapping[], DiacriticsOptions)"/>
        public static string RemoveDiacritics(this string source, IAccentMapping[] mappings, DiacriticsOptions options)
        {
            return DiacriticsMapper.Current.RemoveDiacritics(source, mappings, options);
        }

        /// <inheritdoc cref="IDiacriticsMapper.HasDiacritics(string)"/>
        public static bool HasDiacritics(this string source)
        {
            return DiacriticsMapper.Current.HasDiacritics(source);
        }

        /// <inheritdoc cref="IDiacriticsMapper.HasDiacritics(string, DiacriticsOptions)"/>
        public static bool HasDiacritics(this string source, DiacriticsOptions options)
        {
            return DiacriticsMapper.Current.HasDiacritics(source, options);
        }
    }
}
