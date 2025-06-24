using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class TurkishAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Â', "A" },
			{ 'Ç', "C" },
			{ 'Î', "I" },
			{ 'Ö', "O" },
			{ 'Û', "U" },
			{ 'Ü', "U" },
			{ 'â', "a" },
			{ 'ç', "c" },
			{ 'î', "i" },
			{ 'ö', "o" },
			{ 'û', "u" },
			{ 'ü', "u" },
			{ 'Ğ', "G" },
			{ 'ğ', "g" },
			{ 'İ', "I" },
			{ 'ı', "i" },
			{ 'Ş', "S" },
			{ 'ş', "s" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}