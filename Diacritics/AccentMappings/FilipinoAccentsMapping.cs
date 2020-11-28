using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class FilipinoAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Ñ', new MappingReplacement("N", null, null) },
			{ 'ñ', new MappingReplacement("n", null, null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}