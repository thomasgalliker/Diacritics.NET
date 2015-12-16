
namespace Diacritics.AccentMappings
{
    internal class ItalianAccentsMapping : AccentMapping
    {
        private static readonly char[] ItalianAccents = { 'à', 'è', 'é', 'ì', 'ò', 'ó', 'ù' };

        private static readonly char[] ItalianReplace = { 'a', 'e', 'e', 'i', 'o', 'o', 'u' };

        protected override char[] GetCharacters()
        {
            return ItalianAccents;
        }

        protected override char[] GetReplacements()
        {
            return ItalianReplace;
        }
    }
}
