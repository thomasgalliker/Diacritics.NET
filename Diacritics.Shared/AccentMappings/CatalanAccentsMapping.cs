using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class CatalanAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
            { 'à', "a" },
            { 'è', "e" },
            { 'é', "e" },
            { 'í', "i" },
            { 'ï', "i" },
            { 'ò', "o" },
            { 'ó', "o" },
            { 'ú', "u" },
            { 'ü', "u" },
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}