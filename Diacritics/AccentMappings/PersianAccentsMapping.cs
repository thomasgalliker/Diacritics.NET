using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class PersianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'آ', "ا" },
			{ 'أ', "ا" },
			{ 'ؤ', "و" },
			{ 'ئ', "ي" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}