using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class BulgarianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
            { 'ъ', "ь" },
            { 'ѝ', "и" },
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}