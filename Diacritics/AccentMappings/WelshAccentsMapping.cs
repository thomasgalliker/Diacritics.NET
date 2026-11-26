using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class WelshAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'À', "A" },
			{ 'Á', "A" },
			{ 'Â', "A" },
			{ 'Ä', "A" },
			{ 'È', "E" },
			{ 'É', "E" },
			{ 'Ê', "E" },
			{ 'Ë', "E" },
			{ 'Ì', "I" },
			{ 'Í', "I" },
			{ 'Î', "I" },
			{ 'Ï', "I" },
			{ 'Ò', "O" },
			{ 'Ó', "O" },
			{ 'Ô', "O" },
			{ 'Ö', "O" },
			{ 'Ù', "U" },
			{ 'Ú', "U" },
			{ 'Û', "U" },
			{ 'Ü', "U" },
			{ 'Ý', "Y" },
			{ 'à', "a" },
			{ 'á', "a" },
			{ 'â', "a" },
			{ 'ä', "a" },
			{ 'è', "e" },
			{ 'é', "e" },
			{ 'ê', "e" },
			{ 'ë', "e" },
			{ 'ì', "i" },
			{ 'í', "i" },
			{ 'î', "i" },
			{ 'ï', "i" },
			{ 'ò', "o" },
			{ 'ó', "o" },
			{ 'ô', "o" },
			{ 'ö', "o" },
			{ 'ù', "u" },
			{ 'ú', "u" },
			{ 'û', "u" },
			{ 'ü', "u" },
			{ 'ý', "y" },
			{ 'ÿ', "y" },
			{ 'Ŵ', "W" },
			{ 'ŵ', "w" },
			{ 'Ŷ', "Y" },
			{ 'ŷ', "y" },
			{ 'Ÿ', "Y" },
			{ 'Ẁ', "W" },
			{ 'ẁ', "w" },
			{ 'Ẃ', "W" },
			{ 'ẃ', "w" },
			{ 'Ẅ', "W" },
			{ 'ẅ', "w" },
			{ 'Ỳ', "Y" },
			{ 'ỳ', "y" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}