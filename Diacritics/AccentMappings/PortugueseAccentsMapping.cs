using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class PortugueseAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, char> MappingDictionary = new Dictionary<char, char>
        {
            { 'ã', 'a' },
            { 'á', 'a' },
            { 'â', 'a' },
            { 'à', 'a' },
            { 'é', 'e' },
            { 'ê', 'e' },
            { 'í', 'i' },
            { 'õ', 'o' },
            { 'ó', 'o' },
            { 'ô', 'o' },
            { 'ú', 'u' },
            { 'ü', 'u' },
        };

        public IDictionary<char, char> Mapping { get { return MappingDictionary; } }
    }
}