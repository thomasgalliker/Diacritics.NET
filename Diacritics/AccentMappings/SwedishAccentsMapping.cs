using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class SwedishAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'À', "A" },
			{ 'Ä', "A" },
			{ 'Å', "A" },
			{ 'É', "E" },
			{ 'Ö', "O" },
			{ 'à', "a" },
			{ 'ä', "a" },
			{ 'å', "a" },
			{ 'é', "e" },
			{ 'ö', "o" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}