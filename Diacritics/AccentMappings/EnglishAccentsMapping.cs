using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class EnglishAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
            { 'é', "e" },
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}