
namespace Diacritics.AccentMappings
{
    internal class EnglishAccentsMapping : AccentMapping
    {
        private static readonly char[] EnglishAccents = { 'é' };

        private static readonly char[] EnglishReplace = { 'e' };

        protected override char[] GetCharacters()
        {
            return EnglishAccents;
        }

        protected override char[] GetReplacements()
        {
            return EnglishReplace;
        }
    }
}
