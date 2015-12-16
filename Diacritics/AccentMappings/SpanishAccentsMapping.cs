
namespace Diacritics.AccentMappings
{
    internal class SpanishAccentsMapping : AccentMapping
    {
        private static readonly char[] SpanishAccents = { 'á', 'é', 'í', 'ó', 'ú' };

        private static readonly char[] SpanishReplace = { 'a', 'e', 'i', 'o', 'u' };

        protected override char[] GetCharacters()
        {
            return SpanishAccents;
        }

        protected override char[] GetReplacements()
        {
            return SpanishReplace;
        }
    }
}
