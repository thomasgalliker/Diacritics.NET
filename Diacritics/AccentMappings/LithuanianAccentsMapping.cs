using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class LithuanianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Ą', "A" },
			{ 'ą', "a" },
			{ 'Č', "C" },
			{ 'č', "c" },
			{ 'Ė', "E" },
			{ 'ė', "e" },
			{ 'Ę', "E" },
			{ 'ę', "e" },
			{ 'Į', "I" },
			{ 'į', "i" },
			{ 'Š', "S" },
			{ 'š', "s" },
			{ 'Ū', "U" },
			{ 'ū', "u" },
			{ 'Ų', "U" },
			{ 'ų', "u" },
			{ 'Ž', "Z" },
			{ 'ž', "z" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}