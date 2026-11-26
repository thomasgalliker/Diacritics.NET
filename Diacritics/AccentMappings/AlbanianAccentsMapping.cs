using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class AlbanianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Ç', "C" },
			{ 'Ë', "E" },
			{ 'ç', "c" },
			{ 'ë', "e" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}