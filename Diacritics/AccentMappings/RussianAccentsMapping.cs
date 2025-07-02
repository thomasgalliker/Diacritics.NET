using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class RussianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Ё', "Е" },
			{ 'Й', "И" },
			{ 'й', "и" },
			{ 'ё', "е" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}