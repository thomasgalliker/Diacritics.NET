
namespace Diacritics.AccentMappings
{
    class EstonianAccentsMapping : AccentMapping
    {
        private static readonly char[] EstonianAccents = { 'ä', 'ö', 'õ', 'ü' };

        private static readonly char[] EstonianReplace = { 'a', 'o', 'o', 'u' };

        protected override char[] GetCharacters()
        {
            return EstonianAccents;
        }

        protected override char[] GetReplacements()
        {
            return EstonianReplace;
        }
    }
}
