using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class PolishAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Ó', "O" },
			{ 'ó', "o" },
			{ 'Ą', "A" },
			{ 'ą', "a" },
			{ 'Ć', "C" },
			{ 'ć', "c" },
			{ 'Ę', "E" },
			{ 'ę', "e" },
			{ 'Ł', "L" },
			{ 'ł', "l" },
			{ 'Ń', "N" },
			{ 'ń', "n" },
			{ 'Ś', "S" },
			{ 'ś', "s" },
			{ 'Ź', "Z" },
			{ 'ź', "z" },
			{ 'Ż', "Z" },
			{ 'ż', "z" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}