using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class BosnianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
			{ 'ć', "c" },
			{ 'č', "c" },
			{ 'š', "s" },
			{ 'ž', "z" }
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}