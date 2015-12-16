
namespace Diacritics.AccentMappings
{
    public class BulgarianAccentsMapping : AccentMapping
    {
        private static readonly char[] BulgarianAccents = { 'ъ', 'ѝ' };

        private static readonly char[] BulgarianReplace = { 'ь', 'и' };

        protected override char[] GetCharacters()
        {
            return BulgarianAccents;
        }

        protected override char[] GetReplacements()
        {
            return BulgarianReplace;
        }
    }
}