using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class AzerbaijaniAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Ç', "C" },
			{ 'Ö', "O" },
			{ 'Ü', "U" },
			{ 'ç', "c" },
			{ 'ö', "o" },
			{ 'ü', "u" },
			{ 'Ğ', "G" },
			{ 'ğ', "g" },
			{ 'İ', "I" },
			{ 'Ş', "S" },
			{ 'ş', "s" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}