using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class GermanAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, char> MappingDictionary = new Dictionary<char, char>
        {
            { 'ä', 'a' },
            { 'ö', 'o' },
            { 'ü', 'u' },
            { 'ß', 's' },
        };

        public IDictionary<char, char> Mapping { get { return MappingDictionary; } }
    }
}