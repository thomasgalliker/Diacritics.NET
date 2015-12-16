
namespace Diacritics.AccentMappings
{
    internal class SlovakianAccentsMapping : AccentMapping
    {
        private static readonly char[] SlovakianAccents = { 'á', 'ä', 'č', 'ď', 'é', 'í', 'ĺ', 'ľ', 'ň', 'ó', 'ô', 'ŕ', 'š', 'ť', 'ú', 'ý', 'ž' };

        private static readonly char[] SlovakianReplace = { 'a', 'a', 'c', 'd', 'e', 'i', 'l', 'l', 'n', 'o', 'o', 'r', 's', 't', 'u', 'y', 'z' };

        protected override char[] GetCharacters()
        {
            return SlovakianAccents;
        }

        protected override char[] GetReplacements()
        {
            return SlovakianReplace;
        }
    }
}
