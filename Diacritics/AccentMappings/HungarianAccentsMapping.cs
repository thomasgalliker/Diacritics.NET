
namespace Diacritics.AccentMappings
{
    internal class HungarianAccentsMapping : AccentMapping
    {
        private static readonly char[] HungarianAccents = { 'á', 'é', 'í', 'ö', 'ó', 'ő', 'ü', 'ú', 'ű' };

        private static readonly char[] HungarianReplace = { 'a', 'e', 'i', 'o', 'o', 'o', 'u', 'u', 'u' };

        protected override char[] GetCharacters()
        {
            return HungarianAccents;
        }

        protected override char[] GetReplacements()
        {
            return HungarianReplace;
        }
    }
}
