using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class ArabicAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'آ', new MappingReplacement("ا", null, null) },
			{ 'أ', new MappingReplacement("ا", null, null) },
			{ 'ؤ', new MappingReplacement("و", null, null) },
			{ 'إ', new MappingReplacement("ا", null, null) },
			{ 'ئ', new MappingReplacement("ي", null, null) },
			{ 'ى', new MappingReplacement("ي", null, null) },
			{ 'ٱ', new MappingReplacement("ا", null, null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}