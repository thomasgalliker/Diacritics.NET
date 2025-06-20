using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class CatalanAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'À', "A" },
			{ 'Ç', "C" },
			{ 'È', "E" },
			{ 'É', "E" },
			{ 'Í', "I" },
			{ 'Ï', "I" },
			{ 'Ò', "O" },
			{ 'Ó', "O" },
			{ 'Ú', "U" },
			{ 'Ü', "U" },
			{ 'à', "a" },
			{ 'ç', "c" },
			{ 'è', "e" },
			{ 'é', "e" },
			{ 'í', "i" },
			{ 'ï', "i" },
			{ 'ò', "o" },
			{ 'ó', "o" },
			{ 'ú', "u" },
			{ 'ü', "u" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}