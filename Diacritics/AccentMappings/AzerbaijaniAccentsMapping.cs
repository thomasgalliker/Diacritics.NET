using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class AzerbaijaniAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Ç', new MappingReplacement("C", null, null) },
			{ 'Ö', new MappingReplacement("O", null, null) },
			{ 'Ü', new MappingReplacement("U", null, null) },
			{ 'ç', new MappingReplacement("c", null, null) },
			{ 'ö', new MappingReplacement("o", null, null) },
			{ 'ü', new MappingReplacement("u", null, null) },
			{ 'Ğ', new MappingReplacement("G", null, null) },
			{ 'ğ', new MappingReplacement("g", null, null) },
			{ 'İ', new MappingReplacement("I", null, null) },
			{ 'Ş', new MappingReplacement("S", null, null) },
			{ 'ş', new MappingReplacement("s", null, null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}