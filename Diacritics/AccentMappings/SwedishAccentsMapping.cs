using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class SwedishAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
			{ 'à', "a" },
			{ 'ä', "a" },
			{ 'å', "a" },
			{ 'é', "e" },
			{ 'ö', "o" }
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}