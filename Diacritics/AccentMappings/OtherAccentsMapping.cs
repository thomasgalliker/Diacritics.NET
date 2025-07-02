using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class OtherAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
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

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}
