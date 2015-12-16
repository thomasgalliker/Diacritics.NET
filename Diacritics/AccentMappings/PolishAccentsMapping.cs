
namespace Diacritics.AccentMappings
{
    internal class PolishAccentsMapping : AccentMapping
    {
        private static readonly char[] PolishAccents = { 'ą', 'ć', 'ę', 'ł', 'ń', 'ó', 'ś', 'ż', 'ź' };

        private static readonly char[] PolishReplace = { 'a', 'c', 'e', 'l', 'n', 'o', 's', 'z', 'z' };

        protected override char[] GetCharacters()
        {
            return PolishAccents;
        }

        protected override char[] GetReplacements()
        {
            return PolishReplace;
        }
    }
}
