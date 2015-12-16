

namespace Diacritics.AccentMappings
{
    class CatalanAccentsMapping : AccentMapping
    {
        private static readonly char[] CatalanAccents = { 'à', 'è', 'é', 'í', 'ï', 'ò', 'ó', 'ú', 'ü' };

        private static readonly char[] CatalanReplace = { 'a', 'e', 'e', 'i', 'i', 'o', 'o', 'u', 'u' };

        public CatalanAccentsMapping()
        {
        }

        protected override char[] GetCharacters()
        {
            return CatalanAccents;
        }

        protected override char[] GetReplacements()
        {
            return CatalanReplace;
        }
    }
}
