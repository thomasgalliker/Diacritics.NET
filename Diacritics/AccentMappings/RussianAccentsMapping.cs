using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class RussianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
            { 'ё', "e" },
            { 'й', "и" }
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}