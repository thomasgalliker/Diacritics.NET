
namespace Diacritics.AccentMappings
{
    class GermanAccentsMapping : AccentMapping
    {
        private static readonly char[] GermanAccents = { 'ä', 'ö', 'ü', 'ß' };

        private static readonly char[] GermanReplace = { 'a', 'o', 'u', 's' };

        protected override char[] GetCharacters()
        {
            return GermanAccents;
        }

        protected override char[] GetReplacements()
        {
            return GermanReplace;
        }
    }
}
