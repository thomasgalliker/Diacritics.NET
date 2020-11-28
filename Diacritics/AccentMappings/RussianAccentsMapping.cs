using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class RussianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Ё', new MappingReplacement("Е", null, null) },
			{ 'Й', new MappingReplacement("И", null, null) },
			{ 'й', new MappingReplacement("и", null, null) },
			{ 'ё', new MappingReplacement("е", null, null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}