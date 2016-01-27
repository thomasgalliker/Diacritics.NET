using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class CroatianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, char> MappingDictionary = new Dictionary<char, char>
        {
            { 'č', 'c' },
            { 'ć', 'c' },
            { 'đ', 'd' },
            { 'š', 's' },
            { 'ž', 'z' },
        };

        public IDictionary<char, char> Mapping { get { return MappingDictionary; } }
    }
}