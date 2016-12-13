using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class PolishAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, char> MappingDictionary = new Dictionary<char, char>
        {
            { 'ą', 'a' },
            { 'ć', 'c' },
            { 'ę', 'e' },
            { 'ł', 'l' },
            { 'ń', 'n' },
            { 'ó', 'o' },
            { 'ś', 's' },
            { 'ż', 'z' },
            { 'ź', 'z' },
        };

        public IDictionary<char, char> Mapping { get { return MappingDictionary; } }
    }
}