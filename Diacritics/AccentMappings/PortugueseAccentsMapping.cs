using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class PortugueseAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
            { 'ã', "a" },
            { 'á', "a" },
            { 'â', "a" },
            { 'à', "a" },
            { 'é', "e" },
            { 'ê', "e" },
            { 'í', "i" },
            { 'õ', "o" },
            { 'ó', "o" },
            { 'ô', "o" },
            { 'ú', "u" },
            { 'ü', "u" },
            { 'ç', "c" },
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}
