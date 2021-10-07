using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class HungarianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Á', new MappingReplacement("A", null, null) },
			{ 'É', new MappingReplacement("E", null, null) },
			{ 'Í', new MappingReplacement("I", null, null) },
			{ 'Ó', new MappingReplacement("O", null, null) },
			{ 'Ö', new MappingReplacement("O", null, null) },
			{ 'Ú', new MappingReplacement("U", null, null) },
			{ 'Ü', new MappingReplacement("U", null, null) },
			{ 'á', new MappingReplacement("a", null, null) },
			{ 'é', new MappingReplacement("e", null, null) },
			{ 'í', new MappingReplacement("i", null, null) },
			{ 'ó', new MappingReplacement("o", null, null) },
			{ 'ö', new MappingReplacement("o", null, null) },
			{ 'ú', new MappingReplacement("u", null, null) },
			{ 'ü', new MappingReplacement("u", null, null) },
			{ 'Ő', new MappingReplacement("O", null, null) },
			{ 'ő', new MappingReplacement("o", null, null) },
			{ 'Ű', new MappingReplacement("U", null, null) },
			{ 'ű', new MappingReplacement("u", null, null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}