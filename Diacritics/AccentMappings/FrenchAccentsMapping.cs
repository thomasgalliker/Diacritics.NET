using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class FrenchAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'À', new MappingReplacement("A", null, null) },
			{ 'Â', new MappingReplacement("A", null, null) },
			{ 'Ç', new MappingReplacement("C", null, null) },
			{ 'È', new MappingReplacement("E", null, null) },
			{ 'É', new MappingReplacement("E", null, null) },
			{ 'Ê', new MappingReplacement("E", null, null) },
			{ 'Ë', new MappingReplacement("E", null, null) },
			{ 'Î', new MappingReplacement("I", null, null) },
			{ 'Ï', new MappingReplacement("I", null, null) },
			{ 'Ô', new MappingReplacement("O", null, null) },
			{ 'Ù', new MappingReplacement("U", null, null) },
			{ 'Û', new MappingReplacement("U", null, null) },
			{ 'Ü', new MappingReplacement("U", null, null) },
			{ 'à', new MappingReplacement("a", null, null) },
			{ 'â', new MappingReplacement("a", null, null) },
			{ 'ç', new MappingReplacement("c", null, null) },
			{ 'è', new MappingReplacement("e", null, null) },
			{ 'é', new MappingReplacement("e", null, null) },
			{ 'ê', new MappingReplacement("e", null, null) },
			{ 'ë', new MappingReplacement("e", null, null) },
			{ 'î', new MappingReplacement("i", null, null) },
			{ 'ï', new MappingReplacement("i", null, null) },
			{ 'ô', new MappingReplacement("o", null, null) },
			{ 'ù', new MappingReplacement("u", null, null) },
			{ 'û', new MappingReplacement("u", null, null) },
			{ 'ü', new MappingReplacement("u", null, null) },
			{ 'ÿ', new MappingReplacement("y", null, null) },
			{ 'Ÿ', new MappingReplacement("Y", null, null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}