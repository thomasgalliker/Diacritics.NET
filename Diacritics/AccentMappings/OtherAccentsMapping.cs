using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class OtherAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
            { 'ė', new MappingReplacement("e", null, null) },
            { 'ÿ', new MappingReplacement("y", null, null) },
            { 'ū', new MappingReplacement("u", null, null) },
            { 'ī', new MappingReplacement("i", null, null) },
            { 'į', new MappingReplacement("i", null, null) },
            { 'ø', new MappingReplacement("o", null, null) },
            { 'ō', new MappingReplacement("o", null, null) },
            { 'å', new MappingReplacement("a", null, null) },
            { 'ā', new MappingReplacement("a", null, null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}
