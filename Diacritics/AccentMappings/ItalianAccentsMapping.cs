using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class ItalianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'À', new MappingReplacement("A", null, null) },
			{ 'È', new MappingReplacement("E", null, null) },
			{ 'É', new MappingReplacement("E", null, null) },
			{ 'Ì', new MappingReplacement("I", null, null) },
			{ 'Ò', new MappingReplacement("O", null, null) },
			{ 'Ó', new MappingReplacement("O", null, null) },
			{ 'Ù', new MappingReplacement("U", null, null) },
			{ 'à', new MappingReplacement("a", null, null) },
			{ 'è', new MappingReplacement("e", null, null) },
			{ 'é', new MappingReplacement("e", null, null) },
			{ 'ì', new MappingReplacement("i", null, null) },
			{ 'ò', new MappingReplacement("o", null, null) },
			{ 'ó', new MappingReplacement("o", null, null) },
			{ 'ù', new MappingReplacement("u", null, null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}