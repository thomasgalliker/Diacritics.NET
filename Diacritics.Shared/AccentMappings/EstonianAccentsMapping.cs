using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class EstonianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, char> MappingDictionary = new Dictionary<char, char>
        {
            { 'ä', 'a' },
            { 'ö', 'o' },
            { 'õ', 'o' },
            { 'ü', 'u' },
        };

        public IDictionary<char, char> Mapping { get { return MappingDictionary; } }
    }
}