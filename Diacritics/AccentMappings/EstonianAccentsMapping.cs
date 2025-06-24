using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class EstonianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Ä', "A" },
			{ 'Õ', "O" },
			{ 'Ö', "O" },
			{ 'Ü', "U" },
			{ 'ä', "a" },
			{ 'õ', "o" },
			{ 'ö', "o" },
			{ 'ü', "u" },
			{ 'Š', "S" },
			{ 'š', "s" },
			{ 'Ž', "Z" },
			{ 'ž', "z" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}