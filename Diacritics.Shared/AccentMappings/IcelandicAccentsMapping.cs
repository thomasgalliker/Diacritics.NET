using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class IcelandicAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
            { 'ö', "o" },
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}