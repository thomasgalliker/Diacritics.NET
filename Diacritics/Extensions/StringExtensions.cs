
namespace Diacritics.Extensions
{
    public static class StringExtensions
    {
        public static bool HasDiacritics(this string source)
        {
            return DiacriticsMapper.Current.HasDiacritics(source);
        }

        public static string RemoveDiacritics(this string source)
        {
            return DiacriticsMapper.Current.RemoveDiacritics(source);
        }
    }
}
