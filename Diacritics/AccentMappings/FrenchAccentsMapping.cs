
namespace Diacritics.AccentMappings
{
    class FrenchAccentsMapping : AccentMapping
    {
        private static readonly char[] FrenchAccents = { 'à', 'â', 'ä', 'æ', 'ç', 'é', 'è', 'ê', 'ë', 'î', 'ï', 'ô', 'œ', 'ù', 'û', 'ü' };

        private static readonly char[] FrenchReplace = { 'a', 'a', 'a', 'a', 'c', 'e', 'e', 'e', 'e', 'i', 'i', 'o', 'o', 'u', 'u', 'u' };

        protected override char[] GetCharacters()
        {
            return FrenchAccents;
        }

        protected override char[] GetReplacements()
        {
            return FrenchReplace;
        }
    }
}
