using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class HungarianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Á', "A" },
			{ 'É', "E" },
			{ 'Í', "I" },
			{ 'Ó', "O" },
			{ 'Ö', "O" },
			{ 'Ú', "U" },
			{ 'Ü', "U" },
			{ 'á', "a" },
			{ 'é', "e" },
			{ 'í', "i" },
			{ 'ó', "o" },
			{ 'ö', "o" },
			{ 'ú', "u" },
			{ 'ü', "u" },
			{ 'Ő', "O" },
			{ 'ő', "o" },
			{ 'Ű', "U" },
			{ 'ű', "u" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}