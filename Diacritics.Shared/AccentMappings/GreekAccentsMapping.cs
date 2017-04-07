using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class GreekAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
            { 'ά', "α" },
            { 'έ', "ε" },
            { 'ή', "η" },
            { 'ί', "ι" },
            { 'ϊ', "ι" },
            { 'ΐ', "ι" },
            { 'ό', "ο" },
            { 'ύ', "υ" },
            { 'ϋ', "υ" },
            { 'ΰ', "υ" },
            { 'ώ', "ω" },
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}