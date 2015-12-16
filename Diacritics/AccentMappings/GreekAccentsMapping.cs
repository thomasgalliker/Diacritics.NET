
namespace Diacritics.AccentMappings
{
    class GreekAccentsMapping : AccentMapping
    {
        private static readonly char[] GreekAccents = { 'ά', 'έ', 'ή', 'ί', 'ϊ', 'ΐ', 'ό', 'ύ', 'ϋ', 'ΰ', 'ώ' };

        private static readonly char[] GreekReplace = { 'α', 'ε', 'η', 'ι', 'ι', 'ι', 'ο', 'υ', 'υ', 'υ', 'ω' };

        protected override char[] GetCharacters()
        {
            return GreekAccents;
        }

        protected override char[] GetReplacements()
        {
            return GreekReplace;
        }
    }
}
