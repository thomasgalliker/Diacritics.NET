
namespace Diacritics.AccentMappings
{
    class CroatianAccentsMapping : AccentMapping
    {
        private static readonly char[] CroatianAccents = { 'č', 'ć', 'đ', 'š', 'ž' };

        private static readonly char[] CroatianReplace = { 'c', 'c', 'd', 's', 'z' };

        protected override char[] GetCharacters()
        {
            return CroatianAccents;
        }

        protected override char[] GetReplacements()
        {
            return CroatianReplace;
        }
    }
}
