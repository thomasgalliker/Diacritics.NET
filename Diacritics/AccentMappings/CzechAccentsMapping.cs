using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class CzechAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Á', "A" },
			{ 'É', "E" },
			{ 'Í', "I" },
			{ 'Ó', "O" },
			{ 'Ú', "U" },
			{ 'Ý', "Y" },
			{ 'á', "a" },
			{ 'é', "e" },
			{ 'í', "i" },
			{ 'ó', "o" },
			{ 'ú', "u" },
			{ 'ý', "y" },
			{ 'Č', "C" },
			{ 'č', "c" },
			{ 'Ď', "D" },
			{ 'ď', "d" },
			{ 'Ě', "E" },
			{ 'ě', "e" },
			{ 'Ň', "N" },
			{ 'ň', "n" },
			{ 'Ř', "R" },
			{ 'ř', "r" },
			{ 'Š', "S" },
			{ 'š', "s" },
			{ 'Ť', "T" },
			{ 'ť', "t" },
			{ 'Ů', "U" },
			{ 'ů', "u" },
			{ 'Ž', "Z" },
			{ 'ž', "z" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}