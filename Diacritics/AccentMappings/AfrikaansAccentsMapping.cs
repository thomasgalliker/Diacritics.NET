using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class AfrikaansAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Á', new MappingReplacement("A", null, null) },
			{ 'Â', new MappingReplacement("A", null, null) },
			{ 'È', new MappingReplacement("E", null, null) },
			{ 'É', new MappingReplacement("E", null, null) },
			{ 'Ê', new MappingReplacement("E", null, null) },
			{ 'Ë', new MappingReplacement("E", null, null) },
			{ 'Î', new MappingReplacement("I", null, null) },
			{ 'Ï', new MappingReplacement("I", null, null) },
			{ 'Ô', new MappingReplacement("O", null, null) },
			{ 'Ö', new MappingReplacement("O", null, null) },
			{ 'Û', new MappingReplacement("U", null, null) },
			{ 'á', new MappingReplacement("a", null, null) },
			{ 'â', new MappingReplacement("a", null, null) },
			{ 'è', new MappingReplacement("e", null, null) },
			{ 'é', new MappingReplacement("e", null, null) },
			{ 'ê', new MappingReplacement("e", null, null) },
			{ 'ë', new MappingReplacement("e", null, null) },
			{ 'î', new MappingReplacement("i", null, null) },
			{ 'ï', new MappingReplacement("i", null, null) },
			{ 'ô', new MappingReplacement("o", null, null) },
			{ 'ö', new MappingReplacement("o", null, null) },
			{ 'û', new MappingReplacement("u", null, null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}