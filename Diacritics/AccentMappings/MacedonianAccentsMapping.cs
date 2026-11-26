using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class MacedonianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Ѓ', "Г" },
			{ 'Ќ', "К" },
			{ 'ѓ', "г" },
			{ 'ќ', "к" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}