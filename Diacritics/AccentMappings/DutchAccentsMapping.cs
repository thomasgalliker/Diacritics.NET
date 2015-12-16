
namespace Diacritics.AccentMappings
{
    public class DutchAccentsMapping : AccentMapping
    {
        private static readonly char[] DutchAccents = { 'é', 'ë', 'ï', 'ó', 'ö', 'ü' };

        private static readonly char[] DutchReplace = { 'e', 'e', 'i', 'o', 'o', 'u' };

        protected override char[] GetCharacters()
        {
            return DutchAccents;
        }

        protected override char[] GetReplacements()
        {
            return DutchReplace;
        }
    }
}
