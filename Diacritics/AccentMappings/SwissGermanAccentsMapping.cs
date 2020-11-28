using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class SwissGermanAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Ä', new MappingReplacement("A", "AE", "Ae") },
			{ 'Ö', new MappingReplacement("O", "OE", "Oe") },
			{ 'Ü', new MappingReplacement("U", "UE", "Ue") },
			{ 'ä', new MappingReplacement("a", "ae", null) },
			{ 'ö', new MappingReplacement("o", "oe", null) },
			{ 'ü', new MappingReplacement("u", "ue", null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}