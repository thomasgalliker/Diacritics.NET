using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class EnglishAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, char> MappingDictionary = new Dictionary<char, char>
        {
            { 'é', 'e' },
        };

        public IDictionary<char, char> Mapping { get { return MappingDictionary; } }
    }
}