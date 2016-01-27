using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class IcelandicAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, char> MappingDictionary = new Dictionary<char, char>
        {
            { 'ö', 'o' },
        };

        public IDictionary<char, char> Mapping { get { return MappingDictionary; } }
    }
}