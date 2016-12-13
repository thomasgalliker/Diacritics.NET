using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class DutchAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, char> MappingDictionary = new Dictionary<char, char>
        {
            { 'é', 'e' },
            { 'ë', 'e' },
            { 'ï', 'i' },
            { 'ó', 'o' },
            { 'ö', 'o' },
            { 'ü', 'u' },
        };

        public IDictionary<char, char> Mapping { get { return MappingDictionary; } }
    }
}