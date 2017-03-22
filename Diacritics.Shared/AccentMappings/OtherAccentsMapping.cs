using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class OtherAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, char> MappingDictionary = new Dictionary<char, char>
        {
            { 'ė', 'e' },
            { 'ÿ', 'y' },
            { 'ū', 'u' },
            { 'ī', 'i' },
            { 'į', 'i' },
            { 'ø', 'o' },
            { 'ō', 'o' },
            { 'å', 'a' },
            { 'ā', 'a' }
        };

        public IDictionary<char, char> Mapping { get { return MappingDictionary; } }
    }
}
