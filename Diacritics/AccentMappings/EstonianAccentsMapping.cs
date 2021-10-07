using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class EstonianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Ä', new MappingReplacement("A", null, null) },
			{ 'Õ', new MappingReplacement("O", null, null) },
			{ 'Ö', new MappingReplacement("O", null, null) },
			{ 'Ü', new MappingReplacement("U", null, null) },
			{ 'ä', new MappingReplacement("a", null, null) },
			{ 'õ', new MappingReplacement("o", null, null) },
			{ 'ö', new MappingReplacement("o", null, null) },
			{ 'ü', new MappingReplacement("u", null, null) },
			{ 'Š', new MappingReplacement("S", null, null) },
			{ 'š', new MappingReplacement("s", null, null) },
			{ 'Ž', new MappingReplacement("Z", null, null) },
			{ 'ž', new MappingReplacement("z", null, null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}