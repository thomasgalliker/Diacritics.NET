using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class BulgarianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Й', new MappingReplacement("И", null, null) },
			{ 'й', new MappingReplacement("и", null, null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}