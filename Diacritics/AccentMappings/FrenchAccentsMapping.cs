using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class FrenchAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
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
			{ 'ÿ', "y" }
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}