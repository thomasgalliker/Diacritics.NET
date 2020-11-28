using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class PolishAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Ó', new MappingReplacement("O", null, null) },
			{ 'ó', new MappingReplacement("o", null, null) },
			{ 'Ą', new MappingReplacement("A", null, null) },
			{ 'ą', new MappingReplacement("a", null, null) },
			{ 'Ć', new MappingReplacement("C", null, null) },
			{ 'ć', new MappingReplacement("c", null, null) },
			{ 'Ę', new MappingReplacement("E", null, null) },
			{ 'ę', new MappingReplacement("e", null, null) },
			{ 'Ł', new MappingReplacement("L", null, null) },
			{ 'ł', new MappingReplacement("l", null, null) },
			{ 'Ń', new MappingReplacement("N", null, null) },
			{ 'ń', new MappingReplacement("n", null, null) },
			{ 'Ś', new MappingReplacement("S", null, null) },
			{ 'ś', new MappingReplacement("s", null, null) },
			{ 'Ź', new MappingReplacement("Z", null, null) },
			{ 'ź', new MappingReplacement("z", null, null) },
			{ 'Ż', new MappingReplacement("Z", null, null) },
			{ 'ż', new MappingReplacement("z", null, null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}