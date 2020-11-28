using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class UkarainianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Ї', new MappingReplacement("І", null, null) },
			{ 'Й', new MappingReplacement("И", null, null) },
			{ 'й', new MappingReplacement("и", null, null) },
			{ 'ї', new MappingReplacement("і", null, null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}