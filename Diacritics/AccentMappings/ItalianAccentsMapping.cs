using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class ItalianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'À', "A" },
			{ 'È', "E" },
			{ 'É', "E" },
			{ 'Ì', "I" },
			{ 'Ò', "O" },
			{ 'Ó', "O" },
			{ 'Ù', "U" },
			{ 'à', "a" },
			{ 'è', "e" },
			{ 'é', "e" },
			{ 'ì', "i" },
			{ 'ò', "o" },
			{ 'ó', "o" },
			{ 'ù', "u" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}