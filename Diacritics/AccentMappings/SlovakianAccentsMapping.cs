using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class SlovakianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Á', "A" },
			{ 'Ä', "A" },
			{ 'É', "E" },
			{ 'Í', "I" },
			{ 'Ó', "O" },
			{ 'Ô', "O" },
			{ 'Ú', "U" },
			{ 'Ý', "Y" },
			{ 'á', "a" },
			{ 'ä', "a" },
			{ 'é', "e" },
			{ 'í', "i" },
			{ 'ó', "o" },
			{ 'ô', "o" },
			{ 'ú', "u" },
			{ 'ý', "y" },
			{ 'Č', "C" },
			{ 'č', "c" },
			{ 'Ď', "D" },
			{ 'ď', "d" },
			{ 'Ĺ', "L" },
			{ 'ĺ', "l" },
			{ 'Ľ', "L" },
			{ 'ľ', "l" },
			{ 'Ň', "N" },
			{ 'ň', "n" },
			{ 'Ŕ', "R" },
			{ 'ŕ', "r" },
			{ 'Š', "S" },
			{ 'š', "s" },
			{ 'Ť', "T" },
			{ 'ť', "t" },
			{ 'Ž', "Z" },
			{ 'ž', "z" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}