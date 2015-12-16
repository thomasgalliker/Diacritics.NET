
namespace Diacritics.AccentMappings
{
    internal class IcelandicAccentsMapping : AccentMapping
    {
        private static readonly char[] IcelandicAccents = { 'ö' };

        private static readonly char[] IcelandicReplace = { 'o' };

        protected override char[] GetCharacters()
        {
            return IcelandicAccents;
        }

        protected override char[] GetReplacements()
        {
            return IcelandicReplace;
        }
    }
}
