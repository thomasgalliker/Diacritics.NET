
namespace Diacritics.AccentMappings
{
    internal class RussianAccentsMapping : AccentMapping
    {
        private static readonly char[] RussianAccents = { 'ъ' };

        private static readonly char[] RussianReplace = { 'b' };

        protected override char[] GetCharacters()
        {
            return RussianAccents;
        }

        protected override char[] GetReplacements()
        {
            return RussianReplace;
        }
    }
}
