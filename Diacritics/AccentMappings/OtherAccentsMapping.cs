using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class OtherAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
            { 'ė', "e" },
            { 'ÿ', "y" },
            { 'ū', "u" },
            { 'ī', "i" },
            { 'į', "i" },
            { 'ø', "o" },
            { 'ō', "o" },
            { 'å', "a" },
            { 'ā', "a" }
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}
