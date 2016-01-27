using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class GreekAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, char> MappingDictionary = new Dictionary<char, char>
        {
            { 'ά', 'α' },
            { 'έ', 'ε' },
            { 'ή', 'η' },
            { 'ί', 'ι' },
            { 'ϊ', 'ι' },
            { 'ΐ', 'ι' },
            { 'ό', 'ο' },
            { 'ύ', 'υ' },
            { 'ϋ', 'υ' },
            { 'ΰ', 'υ' },
            { 'ώ', 'ω' },
        };

        public IDictionary<char, char> Mapping { get { return MappingDictionary; } }
    }
}