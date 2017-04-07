using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class GermanAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
            { 'ä', "a" },
            { 'ö', "o" },
            { 'ü', "u" },
            { 'ß', "s" },
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}