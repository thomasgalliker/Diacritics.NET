using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class UkarainianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, char> MappingDictionary = new Dictionary<char, char>
        {
            { 'ї', 'i' },
            { 'ґ', 'r' },
        };
        public IDictionary<char, char> Mapping { get { return MappingDictionary; } }
    }
}
