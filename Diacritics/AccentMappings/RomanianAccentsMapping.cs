using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class RomanianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Â', new MappingReplacement("A", null, null) },
			{ 'Î', new MappingReplacement("I", null, null) },
			{ 'â', new MappingReplacement("a", null, null) },
			{ 'î', new MappingReplacement("i", null, null) },
			{ 'Ă', new MappingReplacement("A", null, null) },
			{ 'ă', new MappingReplacement("a", null, null) },
			{ 'Ș', new MappingReplacement("S", null, null) },
			{ 'ș', new MappingReplacement("s", null, null) },
			{ 'Ț', new MappingReplacement("T", null, null) },
			{ 'ț', new MappingReplacement("t", null, null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}