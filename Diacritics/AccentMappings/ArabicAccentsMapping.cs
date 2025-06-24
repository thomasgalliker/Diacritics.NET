using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class ArabicAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'آ', "ا" },
			{ 'أ', "ا" },
			{ 'ؤ', "و" },
			{ 'إ', "ا" },
			{ 'ئ', "ي" },
			{ 'ى', "ي" },
			{ 'ٱ', "ا" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}