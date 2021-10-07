using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class CroatianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Ć', new MappingReplacement("C", null, null) },
			{ 'ć', new MappingReplacement("c", null, null) },
			{ 'Č', new MappingReplacement("C", null, null) },
			{ 'č', new MappingReplacement("c", null, null) },
			{ 'Š', new MappingReplacement("S", null, null) },
			{ 'š', new MappingReplacement("s", null, null) },
			{ 'Ž', new MappingReplacement("Z", null, null) },
			{ 'ž', new MappingReplacement("z", null, null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}