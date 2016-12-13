using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class BulgarianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, char> MappingDictionary = new Dictionary<char, char>
        {
            { 'ъ', 'ь' },
            { 'ѝ', 'и' },
        };

        public IDictionary<char, char> Mapping { get { return MappingDictionary; } }
    }
}