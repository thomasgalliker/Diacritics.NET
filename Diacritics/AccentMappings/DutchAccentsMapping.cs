using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class DutchAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
            { 'é', "e" },
            { 'ë', "e" },
            { 'ï', "i" },
            { 'ó', "o" },
            { 'ö', "o" },
            { 'ü', "u" },
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}