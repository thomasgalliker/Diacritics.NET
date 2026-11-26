using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class FaroeseAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Á', "A" },
			{ 'Í', "I" },
			{ 'Ó', "O" },
			{ 'Ú', "U" },
			{ 'Ý', "Y" },
			{ 'á', "a" },
			{ 'í', "i" },
			{ 'ó', "o" },
			{ 'ú', "u" },
			{ 'ý', "y" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}