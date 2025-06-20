using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class BelarusianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Ё', "Е" },
			{ 'Ў', "У" },
			{ 'Й', "И" },
			{ 'й', "и" },
			{ 'ё', "е" },
			{ 'ў', "у" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}