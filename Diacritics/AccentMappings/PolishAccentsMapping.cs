using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class PolishAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
            { 'ą', "a" },
            { 'ć', "c" },
            { 'ę', "e" },
            { 'ł', "l" },
            { 'ń', "n" },
            { 'ó', "o" },
            { 'ś', "s" },
            { 'ż', "z" },
            { 'ź', "z" },
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}