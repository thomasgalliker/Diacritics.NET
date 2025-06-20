using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class LatvianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Ā', "A" },
			{ 'ā', "a" },
			{ 'Č', "C" },
			{ 'č', "c" },
			{ 'Ē', "E" },
			{ 'ē', "e" },
			{ 'Ģ', "G" },
			{ 'ģ', "g" },
			{ 'Ī', "I" },
			{ 'ī', "i" },
			{ 'Ķ', "K" },
			{ 'ķ', "k" },
			{ 'Ļ', "L" },
			{ 'ļ', "l" },
			{ 'Ņ', "N" },
			{ 'ņ', "n" },
			{ 'Š', "S" },
			{ 'š', "s" },
			{ 'Ū', "U" },
			{ 'ū', "u" },
			{ 'Ž', "Z" },
			{ 'ž', "z" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}