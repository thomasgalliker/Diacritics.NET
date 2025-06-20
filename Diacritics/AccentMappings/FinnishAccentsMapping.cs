using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class FinnishAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Ä', "A" },
			{ 'Å', "A" },
			{ 'Ö', "O" },
			{ 'ä', "a" },
			{ 'å', "a" },
			{ 'ö', "o" },
			{ 'Š', "S" },
			{ 'š', "s" },
			{ 'Ž', "Z" },
			{ 'ž', "z" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}