using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class IcelandicAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Á', "A" },
			{ 'É', "E" },
			{ 'Í', "I" },
			{ 'Ó', "O" },
			{ 'Ö', "O" },
			{ 'Ú', "U" },
			{ 'Ý', "Y" },
			{ 'á', "a" },
			{ 'é', "e" },
			{ 'í', "i" },
			{ 'ó', "o" },
			{ 'ö', "o" },
			{ 'ú', "u" },
			{ 'ý', "y" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}