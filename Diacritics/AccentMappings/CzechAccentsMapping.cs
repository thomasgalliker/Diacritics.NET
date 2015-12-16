
namespace Diacritics.AccentMappings
{
    class CzechAccentsMapping : AccentMapping
    {
        private static readonly char[] CzechAccents = { 'ã', 'á', 'á', 'č', 'ď', 'é', 'ě', 'í', 'ň', 'ó', 'ř', 'š', 'ť', 'ú', 'ů', 'ý', 'ž' };

        private static readonly char[] CzechReplace = { 'a', 'a', 'a', 'c', 'd', 'e', 'e', 'i', 'n', 'o', 'r', 's', 't', 'u', 'u', 'y', 'z' };

        protected override char[] GetCharacters()
        {
            return CzechAccents;
        }

        protected override char[] GetReplacements()
        {
            return CzechReplace;
        }
    }
}
