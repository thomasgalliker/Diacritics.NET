using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class CatalanAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
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

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}