using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class TonganAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Á', new MappingReplacement("A", null, null) },
			{ 'É', new MappingReplacement("E", null, null) },
			{ 'Í', new MappingReplacement("I", null, null) },
			{ 'Ó', new MappingReplacement("O", null, null) },
			{ 'Ú', new MappingReplacement("U", null, null) },
			{ 'á', new MappingReplacement("a", null, null) },
			{ 'é', new MappingReplacement("e", null, null) },
			{ 'í', new MappingReplacement("i", null, null) },
			{ 'ó', new MappingReplacement("o", null, null) },
			{ 'ú', new MappingReplacement("u", null, null) },
			{ 'Ā', new MappingReplacement("A", null, null) },
			{ 'ā', new MappingReplacement("a", null, null) },
			{ 'Ē', new MappingReplacement("E", null, null) },
			{ 'ē', new MappingReplacement("e", null, null) },
			{ 'Ī', new MappingReplacement("I", null, null) },
			{ 'ī', new MappingReplacement("i", null, null) },
			{ 'Ō', new MappingReplacement("O", null, null) },
			{ 'ō', new MappingReplacement("o", null, null) },
			{ 'Ū', new MappingReplacement("U", null, null) },
			{ 'ū', new MappingReplacement("u", null, null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}