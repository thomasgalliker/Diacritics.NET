using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class AzerbaijaniAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
			{ 'ç', "c" },
			{ 'ö', "o" },
			{ 'ü', "u" },
			{ 'ğ', "g" },
			{ 'ş', "s" }
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}