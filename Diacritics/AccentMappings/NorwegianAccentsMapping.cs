using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class NorwegianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'À', "A" },
			{ 'Å', "A" },
			{ 'É', "E" },
			{ 'Ò', "O" },
			{ 'Ó', "O" },
			{ 'Ô', "O" },
			{ 'à', "a" },
			{ 'å', "a" },
			{ 'é', "e" },
			{ 'ò', "o" },
			{ 'ó', "o" },
			{ 'ô', "o" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}