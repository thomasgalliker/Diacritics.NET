using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class UkarainianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Ї', "І" },
			{ 'Й', "И" },
			{ 'й', "и" },
			{ 'ї', "і" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}