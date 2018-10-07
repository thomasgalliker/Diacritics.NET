using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class RomanianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
            { 'ă', "a" },
            { 'â', "a" },
            { 'î', "i" },
            { 'ş', "s" },
            { 'ș', "s" },
            { 'ţ', "t" },
            { 'ț', "t" },
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}