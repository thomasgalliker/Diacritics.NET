using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class SwedishAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'À', new MappingReplacement("A", null, null) },
			{ 'Ä', new MappingReplacement("A", null, null) },
			{ 'Å', new MappingReplacement("A", null, null) },
			{ 'É', new MappingReplacement("E", null, null) },
			{ 'Ö', new MappingReplacement("O", null, null) },
			{ 'à', new MappingReplacement("a", null, null) },
			{ 'ä', new MappingReplacement("a", null, null) },
			{ 'å', new MappingReplacement("a", null, null) },
			{ 'é', new MappingReplacement("e", null, null) },
			{ 'ö', new MappingReplacement("o", null, null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}