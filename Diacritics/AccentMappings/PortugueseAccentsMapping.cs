using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class PortugueseAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'À', "A" },
			{ 'Á', "A" },
			{ 'Â', "A" },
			{ 'Ã', "A" },
			{ 'Ç', "C" },
			{ 'É', "E" },
			{ 'Ê', "E" },
			{ 'Í', "I" },
			{ 'Ò', "O" },
			{ 'Ó', "O" },
			{ 'Ô', "O" },
			{ 'Õ', "O" },
			{ 'Ú', "U" },
			{ 'à', "a" },
			{ 'á', "a" },
			{ 'â', "a" },
			{ 'ã', "a" },
			{ 'ç', "c" },
			{ 'é', "e" },
			{ 'ê', "e" },
			{ 'í', "i" },
			{ 'ò', "o" },
			{ 'ó', "o" },
			{ 'ô', "o" },
			{ 'õ', "o" },
			{ 'ú', "u" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}