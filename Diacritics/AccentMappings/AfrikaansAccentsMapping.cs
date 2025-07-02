using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class AfrikaansAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Á', "A" },
			{ 'Â', "A" },
			{ 'È', "E" },
			{ 'É', "E" },
			{ 'Ê', "E" },
			{ 'Ë', "E" },
			{ 'Î', "I" },
			{ 'Ï', "I" },
			{ 'Ô', "O" },
			{ 'Ö', "O" },
			{ 'Û', "U" },
			{ 'á', "a" },
			{ 'â', "a" },
			{ 'è', "e" },
			{ 'é', "e" },
			{ 'ê', "e" },
			{ 'ë', "e" },
			{ 'î', "i" },
			{ 'ï', "i" },
			{ 'ô', "o" },
			{ 'ö', "o" },
			{ 'û', "u" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}