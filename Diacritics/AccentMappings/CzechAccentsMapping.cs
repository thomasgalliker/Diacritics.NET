using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class CzechAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Á', new MappingReplacement("A", null, null) },
			{ 'É', new MappingReplacement("E", null, null) },
			{ 'Í', new MappingReplacement("I", null, null) },
			{ 'Ó', new MappingReplacement("O", null, null) },
			{ 'Ú', new MappingReplacement("U", null, null) },
			{ 'Ý', new MappingReplacement("Y", null, null) },
			{ 'á', new MappingReplacement("a", null, null) },
			{ 'é', new MappingReplacement("e", null, null) },
			{ 'í', new MappingReplacement("i", null, null) },
			{ 'ó', new MappingReplacement("o", null, null) },
			{ 'ú', new MappingReplacement("u", null, null) },
			{ 'ý', new MappingReplacement("y", null, null) },
			{ 'Č', new MappingReplacement("C", null, null) },
			{ 'č', new MappingReplacement("c", null, null) },
			{ 'Ď', new MappingReplacement("D", null, null) },
			{ 'ď', new MappingReplacement("d", null, null) },
			{ 'Ě', new MappingReplacement("E", null, null) },
			{ 'ě', new MappingReplacement("e", null, null) },
			{ 'Ň', new MappingReplacement("N", null, null) },
			{ 'ň', new MappingReplacement("n", null, null) },
			{ 'Ř', new MappingReplacement("R", null, null) },
			{ 'ř', new MappingReplacement("r", null, null) },
			{ 'Š', new MappingReplacement("S", null, null) },
			{ 'š', new MappingReplacement("s", null, null) },
			{ 'Ť', new MappingReplacement("T", null, null) },
			{ 'ť', new MappingReplacement("t", null, null) },
			{ 'Ů', new MappingReplacement("U", null, null) },
			{ 'ů', new MappingReplacement("u", null, null) },
			{ 'Ž', new MappingReplacement("Z", null, null) },
			{ 'ž', new MappingReplacement("z", null, null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}