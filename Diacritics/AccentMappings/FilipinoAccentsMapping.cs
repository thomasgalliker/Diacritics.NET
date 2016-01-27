using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class FilipinoAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, char> MappingDictionary = new Dictionary<char, char>
        {
            { 'á', 'a' },
            { 'à', 'a' },
            { 'â', 'a' },
            { 'é', 'e' },
            { 'è', 'e' },
            { 'ê', 'e' },
            { 'í', 'i' },
            { 'ì', 'i' },
            { 'î', 'i' },
            { 'ó', 'o' },
            { 'ò', 'o' },
            { 'ô', 'o' },
            { 'ú', 'u' },
            { 'ù', 'u' },
            { 'û', 'u' },
        };

        public IDictionary<char, char> Mapping { get { return MappingDictionary; } }
    }
}