using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class SlovakianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
            { 'á', "a" },
            { 'ä', "a" },
            { 'č', "c" },
            { 'ď', "d" },
            { 'é', "e" },
            { 'í', "i" },
            { 'ĺ', "l" },
            { 'ľ', "l" },
            { 'ň', "n" },
            { 'ó', "o" },
            { 'ô', "o" },
            { 'ŕ', "r" },
            { 'š', "s" },
            { 'ť', "t" },
            { 'ú', "u" },
            { 'ý', "y" },
            { 'ž', "z" },
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}