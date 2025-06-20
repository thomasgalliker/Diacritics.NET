using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class CroatianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Ć', "C" },
			{ 'ć', "c" },
			{ 'Č', "C" },
			{ 'č', "c" },
			{ 'Š', "S" },
			{ 'š', "s" },
			{ 'Ž', "Z" },
			{ 'ž', "z" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}