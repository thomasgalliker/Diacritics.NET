using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class DutchAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Á', "A" },
			{ 'Ä', "A" },
			{ 'É', "E" },
			{ 'Ë', "E" },
			{ 'Í', "I" },
			{ 'Ï', "I" },
			{ 'Ó', "O" },
			{ 'Ö', "O" },
			{ 'Ú', "U" },
			{ 'Ü', "U" },
			{ 'á', "a" },
			{ 'ä', "a" },
			{ 'é', "e" },
			{ 'ë', "e" },
			{ 'í', "i" },
			{ 'ï', "i" },
			{ 'ó', "o" },
			{ 'ö', "o" },
			{ 'ú', "u" },
			{ 'ü', "u" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}