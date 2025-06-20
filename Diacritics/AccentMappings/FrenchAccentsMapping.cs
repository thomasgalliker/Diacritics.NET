using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class FrenchAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'À', "A" },
			{ 'Â', "A" },
			{ 'Ç', "C" },
			{ 'È', "E" },
			{ 'É', "E" },
			{ 'Ê', "E" },
			{ 'Ë', "E" },
			{ 'Î', "I" },
			{ 'Ï', "I" },
			{ 'Ô', "O" },
			{ 'Ù', "U" },
			{ 'Û', "U" },
			{ 'Ü', "U" },
			{ 'à', "a" },
			{ 'â', "a" },
			{ 'ç', "c" },
			{ 'è', "e" },
			{ 'é', "e" },
			{ 'ê', "e" },
			{ 'ë', "e" },
			{ 'î', "i" },
			{ 'ï', "i" },
			{ 'ô', "o" },
			{ 'ù', "u" },
			{ 'û', "u" },
			{ 'ü', "u" },
			{ 'ÿ', "y" },
			{ 'Ÿ', "Y" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}