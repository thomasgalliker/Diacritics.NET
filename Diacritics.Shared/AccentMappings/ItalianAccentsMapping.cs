using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class ItalianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
            { 'à', "a" },
            { 'è', "e" },
            { 'é', "e" },
            { 'ì', "i" },
            { 'ò', "o" },
            { 'ó', "o" },
            { 'ù', "u" },
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}