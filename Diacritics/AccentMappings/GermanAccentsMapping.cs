using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class GermanAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
			{ 'ß', "ss" },
			{ 'ä', "a" },
			{ 'ö', "o" },
			{ 'ü', "u" }
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}