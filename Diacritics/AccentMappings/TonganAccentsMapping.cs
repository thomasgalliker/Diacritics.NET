using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class TonganAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Á', "A" },
			{ 'É', "E" },
			{ 'Í', "I" },
			{ 'Ó', "O" },
			{ 'Ú', "U" },
			{ 'á', "a" },
			{ 'é', "e" },
			{ 'í', "i" },
			{ 'ó', "o" },
			{ 'ú', "u" },
			{ 'Ā', "A" },
			{ 'ā', "a" },
			{ 'Ē', "E" },
			{ 'ē', "e" },
			{ 'Ī', "I" },
			{ 'ī', "i" },
			{ 'Ō', "O" },
			{ 'ō', "o" },
			{ 'Ū', "U" },
			{ 'ū', "u" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}