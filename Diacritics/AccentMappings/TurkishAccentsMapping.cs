
namespace Diacritics.AccentMappings
{
    internal class TurkishAccentsMapping : AccentMapping
    {
        private static readonly char[] TurkishAccents = { 'ç', 'é', 'ë', 'ğ', 'İ', 'ï', 'ó', 'ö', 'ü' };

        private static readonly char[] TurkishReplace = { 'c', 'e', 'e', 'g', 'i', 'i', 'o', 'o', 'u' };

        protected override char[] GetCharacters()
        {
            return TurkishAccents;
        }

        protected override char[] GetReplacements()
        {
            return TurkishReplace;
        }
    }
}
