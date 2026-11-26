using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class DanishAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Å', "A" },
			{ 'å', "a" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}