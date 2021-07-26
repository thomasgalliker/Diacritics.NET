using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class GreekAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Ά', new MappingReplacement("Α", null, null) },
			{ 'Έ', new MappingReplacement("Ε", null, null) },
			{ 'Ή', new MappingReplacement("Η", null, null) },
			{ 'Ί', new MappingReplacement("Ι", null, null) },
			{ 'Ό', new MappingReplacement("Ο", null, null) },
			{ 'Ύ', new MappingReplacement("Υ", null, null) },
			{ 'Ώ', new MappingReplacement("Ω", null, null) },
			{ 'ΐ', new MappingReplacement("ι", null, null) },
			{ 'Ϊ', new MappingReplacement("Ι", null, null) },
			{ 'Ϋ', new MappingReplacement("Υ", null, null) },
			{ 'ά', new MappingReplacement("α", null, null) },
			{ 'έ', new MappingReplacement("ε", null, null) },
			{ 'ή', new MappingReplacement("η", null, null) },
			{ 'ί', new MappingReplacement("ι", null, null) },
			{ 'ΰ', new MappingReplacement("υ", null, null) },
			{ 'ϊ', new MappingReplacement("ι", null, null) },
			{ 'ϋ', new MappingReplacement("υ", null, null) },
			{ 'ό', new MappingReplacement("ο", null, null) },
			{ 'ύ', new MappingReplacement("υ", null, null) },
			{ 'ώ', new MappingReplacement("ω", null, null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}