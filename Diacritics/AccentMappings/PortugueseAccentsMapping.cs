using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class PortugueseAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'À', new MappingReplacement("A", null, null) },
			{ 'Á', new MappingReplacement("A", null, null) },
			{ 'Â', new MappingReplacement("A", null, null) },
			{ 'Ã', new MappingReplacement("A", null, null) },
			{ 'Ç', new MappingReplacement("C", null, null) },
			{ 'É', new MappingReplacement("E", null, null) },
			{ 'Ê', new MappingReplacement("E", null, null) },
			{ 'Í', new MappingReplacement("I", null, null) },
			{ 'Ò', new MappingReplacement("O", null, null) },
			{ 'Ó', new MappingReplacement("O", null, null) },
			{ 'Ô', new MappingReplacement("O", null, null) },
			{ 'Õ', new MappingReplacement("O", null, null) },
			{ 'Ú', new MappingReplacement("U", null, null) },
			{ 'à', new MappingReplacement("a", null, null) },
			{ 'á', new MappingReplacement("a", null, null) },
			{ 'â', new MappingReplacement("a", null, null) },
			{ 'ã', new MappingReplacement("a", null, null) },
			{ 'ç', new MappingReplacement("c", null, null) },
			{ 'é', new MappingReplacement("e", null, null) },
			{ 'ê', new MappingReplacement("e", null, null) },
			{ 'í', new MappingReplacement("i", null, null) },
			{ 'ò', new MappingReplacement("o", null, null) },
			{ 'ó', new MappingReplacement("o", null, null) },
			{ 'ô', new MappingReplacement("o", null, null) },
			{ 'õ', new MappingReplacement("o", null, null) },
            { 'º', new MappingReplacement("o", null, null) },
			{ 'ú', new MappingReplacement("u", null, null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}
