using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class CatalanAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'À', new MappingReplacement("A", null, null) },
			{ 'Ç', new MappingReplacement("C", null, null) },
			{ 'È', new MappingReplacement("E", null, null) },
			{ 'É', new MappingReplacement("E", null, null) },
			{ 'Í', new MappingReplacement("I", null, null) },
			{ 'Ï', new MappingReplacement("I", null, null) },
			{ 'Ò', new MappingReplacement("O", null, null) },
			{ 'Ó', new MappingReplacement("O", null, null) },
			{ 'Ú', new MappingReplacement("U", null, null) },
			{ 'Ü', new MappingReplacement("U", null, null) },
			{ 'à', new MappingReplacement("a", null, null) },
			{ 'ç', new MappingReplacement("c", null, null) },
			{ 'è', new MappingReplacement("e", null, null) },
			{ 'é', new MappingReplacement("e", null, null) },
			{ 'í', new MappingReplacement("i", null, null) },
			{ 'ï', new MappingReplacement("i", null, null) },
			{ 'ò', new MappingReplacement("o", null, null) },
			{ 'ó', new MappingReplacement("o", null, null) },
			{ 'ú', new MappingReplacement("u", null, null) },
			{ 'ü', new MappingReplacement("u", null, null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}