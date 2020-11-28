using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class OtherAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
            { 'ė', new MappingReplacement("e", "", "") },
            { 'ÿ', new MappingReplacement("y", "", "") },
            { 'ū', new MappingReplacement("u", "", "") },
            { 'ī', new MappingReplacement("i", "", "") },
            { 'į', new MappingReplacement("i", "", "") },
            { 'ø', new MappingReplacement("o", "", "") },
            { 'ō', new MappingReplacement("o", "", "") },
            { 'å', new MappingReplacement("a", "", "") },
            { 'ā', new MappingReplacement("a", "", "") }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}
