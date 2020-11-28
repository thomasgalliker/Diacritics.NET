using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class TurkishAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Â', new MappingReplacement("A", null, null) },
			{ 'Ç', new MappingReplacement("C", null, null) },
			{ 'Î', new MappingReplacement("I", null, null) },
			{ 'Ö', new MappingReplacement("O", null, null) },
			{ 'Û', new MappingReplacement("U", null, null) },
			{ 'Ü', new MappingReplacement("U", null, null) },
			{ 'â', new MappingReplacement("a", null, null) },
			{ 'ç', new MappingReplacement("c", null, null) },
			{ 'î', new MappingReplacement("i", null, null) },
			{ 'ö', new MappingReplacement("o", null, null) },
			{ 'û', new MappingReplacement("u", null, null) },
			{ 'ü', new MappingReplacement("u", null, null) },
			{ 'Ğ', new MappingReplacement("G", null, null) },
			{ 'ğ', new MappingReplacement("g", null, null) },
			{ 'İ', new MappingReplacement("I", null, null) },
			{ 'ı', new MappingReplacement("i", null, null) },
			{ 'Ş', new MappingReplacement("S", null, null) },
			{ 'ş', new MappingReplacement("s", null, null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}