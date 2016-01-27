using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class RomanianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, char> MappingDictionary = new Dictionary<char, char>
        {
            { 'ă', 'a' },
            { 'â', 'a' },
            { 'î', 'i' },
            { 'ş', 's' },
            { 'ș', 's' },
            { 'ţ', 't' },
            { 'ț', 't' },
        };

        public IDictionary<char, char> Mapping { get { return MappingDictionary; } }
    }
}