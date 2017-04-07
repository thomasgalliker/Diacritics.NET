using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class CzechAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
            { 'ã', "a" },
            { 'á', "a" },
            { 'č', "c" },
            { 'ď', "d" },
            { 'é', "e" },
            { 'ě', "e" },
            { 'í', "i" },
            { 'ň', "n" },
            { 'ó', "o" },
            { 'ř', "r" },
            { 'š', "s" },
            { 'ť', "t" },
            { 'ú', "u" },
            { 'ů', "u" },
            { 'ý', "y" },
            { 'ž', "z" },
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}