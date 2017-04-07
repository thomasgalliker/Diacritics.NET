using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class SpanishAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
            { 'á', "a" },
            { 'é', "e" },
            { 'í', "i" },
            { 'ó', "o" },
            { 'ú', "u" },
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}