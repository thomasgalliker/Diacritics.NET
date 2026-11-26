using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class GalicianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Á', "A" },
			{ 'É', "E" },
			{ 'Í', "I" },
			{ 'Ñ', "N" },
			{ 'Ó', "O" },
			{ 'Ú', "U" },
			{ 'Ü', "U" },
			{ 'á', "a" },
			{ 'é', "e" },
			{ 'í', "i" },
			{ 'ñ', "n" },
			{ 'ó', "o" },
			{ 'ú', "u" },
			{ 'ü', "u" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}