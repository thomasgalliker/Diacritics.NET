
namespace Diacritics.AccentMappings
{
    internal class PortugueseAccentsMapping : AccentMapping
    {
        private static readonly char[] PortugueseAccents = { 'ã', 'á', 'â', 'à', 'é', 'ê', 'í', 'õ', 'ó', 'ô', 'ú', 'ü' };

        private static readonly char[] PortugueseReplace = { 'a', 'a', 'a', 'a', 'e', 'e', 'i', 'o', 'o', 'o', 'u', 'u' };

        protected override char[] GetCharacters()
        {
            return PortugueseAccents;
        }

        protected override char[] GetReplacements()
        {
            return PortugueseReplace;
        }
    }
}
