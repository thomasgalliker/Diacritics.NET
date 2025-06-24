using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class GreekAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Ά', "Α" },
			{ 'Έ', "Ε" },
			{ 'Ή', "Η" },
			{ 'Ί', "Ι" },
			{ 'Ό', "Ο" },
			{ 'Ύ', "Υ" },
			{ 'Ώ', "Ω" },
			{ 'ΐ', "ι" },
			{ 'Ϊ', "Ι" },
			{ 'Ϋ', "Υ" },
			{ 'ά', "α" },
			{ 'έ', "ε" },
			{ 'ή', "η" },
			{ 'ί', "ι" },
			{ 'ΰ', "υ" },
			{ 'ϊ', "ι" },
			{ 'ϋ', "υ" },
			{ 'ό', "ο" },
			{ 'ύ', "υ" },
			{ 'ώ', "ω" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}