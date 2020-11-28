using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class AfrikaansAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
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

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}