using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class HungarianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, char> MappingDictionary = new Dictionary<char, char>
        {
            { 'á', 'a' },
            { 'é', 'e' },
            { 'í', 'i' },
            { 'ö', 'o' },
            { 'ó', 'o' },
            { 'ő', 'o' },
            { 'ü', 'u' },
            { 'ú', 'u' },
            { 'ű', 'u' },
        };

        public IDictionary<char, char> Mapping { get { return MappingDictionary; } }
    }
}