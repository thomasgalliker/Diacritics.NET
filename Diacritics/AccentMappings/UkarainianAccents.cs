
namespace Diacritics.AccentMappings
{
    internal class UkarainianAccentsMapping : AccentMapping
    {
        private static readonly char[] UkarainianAccents = { 'ї', 'ґ' };

        private static readonly char[] UkarainianReplace = { 'i', 'r' };

        protected override char[] GetCharacters()
        {
            return UkarainianAccents;
        }

        protected override char[] GetReplacements()
        {
            return UkarainianReplace;
        }
    }
}
