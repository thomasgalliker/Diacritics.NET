
namespace Diacritics.AccentMappings
{
    internal class RomanianAccentsMapping : AccentMapping
    {
        private static readonly char[] RomanianAccents = { 'ă', 'â', 'î', 'ş', 'ș', 'ţ', 'ț' };

        private static readonly char[] RomanianReplace = { 'a', 'a', 'i', 's', 's', 't', 't' };

        protected override char[] GetCharacters()
        {
            return RomanianAccents;
        }

        protected override char[] GetReplacements()
        {
            return RomanianReplace;
        }
    }
}
