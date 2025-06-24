using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class SpanishAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ '¡', new MappingReplacement(null, "!", null) },
			{ '¿', new MappingReplacement(null, "?", null) },
			{ 'Á', "A" },
			{ 'É', "E" },
			{ 'Í', "I" },
			{ 'Ñ', "N" },
			{ 'Ó', "O" },
			{ 'Ú', "U" },
			{ 'Ü', "U" },
			{ 'Ý', "Y" },
			{ 'á', "a" },
			{ 'é', "e" },
			{ 'í', "i" },
			{ 'ï', "i" },
			{ 'ñ', "n" },
			{ 'ó', "o" },
			{ 'ú', "u" },
			{ 'ü', "u" },
			{ 'ý', "y" },
			{ '⸘', new MappingReplacement(null, "?!", null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}