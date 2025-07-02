using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class RomanianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Â', "A" },
			{ 'Î', "I" },
			{ 'â', "a" },
			{ 'î', "i" },
			{ 'Ă', "A" },
			{ 'ă', "a" },
			{ 'Ș', "S" },
			{ 'ș', "s" },
			{ 'Ț', "T" },
			{ 'ț', "t" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}