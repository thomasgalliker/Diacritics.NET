using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class EstonianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
            { 'ä', "a" },
            { 'ö', "o" },
            { 'õ', "o" },
            { 'ü', "u" },
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}