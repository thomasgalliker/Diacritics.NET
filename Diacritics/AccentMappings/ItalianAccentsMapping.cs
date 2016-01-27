using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class ItalianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, char> MappingDictionary = new Dictionary<char, char>
        {
            { 'à', 'a' },
            { 'è', 'e' },
            { 'é', 'e' },
            { 'ì', 'i' },
            { 'ò', 'o' },
            { 'ó', 'o' },
            { 'ù', 'u' },
        };

        public IDictionary<char, char> Mapping { get { return MappingDictionary; } }
    }
}