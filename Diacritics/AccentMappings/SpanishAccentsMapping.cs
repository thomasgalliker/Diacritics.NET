using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class SpanishAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ '¡', new MappingReplacement(null, "!", null) },
			{ '¿', new MappingReplacement(null, "?", null) },
			{ 'Á', new MappingReplacement("A", null, null) },
			{ 'É', new MappingReplacement("E", null, null) },
			{ 'Í', new MappingReplacement("I", null, null) },
			{ 'Ñ', new MappingReplacement("N", null, null) },
			{ 'Ó', new MappingReplacement("O", null, null) },
			{ 'Ú', new MappingReplacement("U", null, null) },
			{ 'Ü', new MappingReplacement("U", null, null) },
			{ 'Ý', new MappingReplacement("Y", null, null) },
			{ 'á', new MappingReplacement("a", null, null) },
			{ 'é', new MappingReplacement("e", null, null) },
			{ 'í', new MappingReplacement("i", null, null) },
			{ 'ï', new MappingReplacement("i", null, null) },
			{ 'ñ', new MappingReplacement("n", null, null) },
			{ 'ó', new MappingReplacement("o", null, null) },
			{ 'ú', new MappingReplacement("u", null, null) },
			{ 'ü', new MappingReplacement("u", null, null) },
			{ 'ý', new MappingReplacement("y", null, null) },
			{ '⸘', new MappingReplacement(null, "?!", null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}