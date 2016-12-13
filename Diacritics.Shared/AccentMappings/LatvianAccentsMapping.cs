using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class LatvianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, char> MappingDictionary = new Dictionary<char, char>
        {
            { 'ē', 'e' },
        };

        public IDictionary<char, char> Mapping { get { return MappingDictionary; } }
    }
}