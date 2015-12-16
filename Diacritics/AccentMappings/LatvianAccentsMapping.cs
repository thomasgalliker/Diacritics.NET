
namespace Diacritics.AccentMappings
{
    internal class LatvianAccentsMapping : AccentMapping
    {
        private static readonly char[] LatvianAccents = { 'ē' };

        private static readonly char[] LatvianReplace = { 'e' };

        protected override char[] GetCharacters()
        {
            return LatvianAccents;
        }

        protected override char[] GetReplacements()
        {
            return LatvianReplace;
        }
    }
}
