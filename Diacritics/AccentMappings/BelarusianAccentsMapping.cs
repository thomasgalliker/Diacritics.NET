using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class BelarusianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
			{ 'й', "и" },
			{ 'ё', "е" },
			{ 'ў', "у" }
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}