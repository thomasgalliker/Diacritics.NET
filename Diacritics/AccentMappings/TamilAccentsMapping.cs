using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class TamilAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'ஔ', new MappingReplacement("ஒ", null, null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}