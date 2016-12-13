
namespace Diacritics.Extensions
{
    public static class StringExtensions
    {
        public static bool HasDiacritics(this string source)
        {
            return StaticDiacritics.Current.HasDiacritics(source);
        }

        public static string RemoveDiacritics(this string source)
        {
            return StaticDiacritics.Current.RemoveDiacritics(source);
        }
    }
}
