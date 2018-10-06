using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class UkarainianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
            { 'ї', "i" },
            { 'ґ', "r" },
        };
        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}
