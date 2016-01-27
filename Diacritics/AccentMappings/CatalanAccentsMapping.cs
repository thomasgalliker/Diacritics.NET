using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class CatalanAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, char> MappingDictionary = new Dictionary<char, char>
        {
            { 'à', 'a' },
            { 'è', 'e' },
            { 'é', 'e' },
            { 'í', 'i' },
            { 'ï', 'i' },
            { 'ò', 'o' },
            { 'ó', 'o' },
            { 'ú', 'u' },
            { 'ü', 'u' },
        };

        public IDictionary<char, char> Mapping { get { return MappingDictionary; } }
    }
}