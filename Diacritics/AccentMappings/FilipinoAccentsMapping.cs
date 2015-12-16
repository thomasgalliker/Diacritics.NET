
namespace Diacritics.AccentMappings
{
    class FilipinoAccentsMapping : AccentMapping
    {
        private static readonly char[] FilipinoAccents = { 'á', 'à', 'â', 'é', 'è', 'ê', 'í', 'ì', 'î', 'ó', 'ò', 'ô', 'ú', 'ù', 'û' };

        private static readonly char[] FilipinoReplace = { 'a', 'a', 'a', 'e', 'e', 'e', 'i', 'i', 'i', 'o', 'o', 'o', 'u', 'u', 'u' };

        protected override char[] GetCharacters()
        {
            return FilipinoAccents;
        }

        protected override char[] GetReplacements()
        {
            return FilipinoReplace;
        }
    }
}
