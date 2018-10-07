using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class LatvianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
            { 'ē', "e" },
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}