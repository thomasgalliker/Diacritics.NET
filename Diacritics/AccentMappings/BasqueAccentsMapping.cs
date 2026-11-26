using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class BasqueAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Ç', "C" },
			{ 'Ñ', "N" },
			{ 'ç', "c" },
			{ 'ñ', "n" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}