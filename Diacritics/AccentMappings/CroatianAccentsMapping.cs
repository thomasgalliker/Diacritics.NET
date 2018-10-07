using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class CroatianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
            { 'č', "c" },
            { 'ć', "c" },
            { 'đ', "d" },
            { 'š', "s" },
            { 'ž', "z" },
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}