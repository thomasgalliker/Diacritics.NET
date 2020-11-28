using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class LatvianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'Ā', new MappingReplacement("A", null, null) },
			{ 'ā', new MappingReplacement("a", null, null) },
			{ 'Č', new MappingReplacement("C", null, null) },
			{ 'č', new MappingReplacement("c", null, null) },
			{ 'Ē', new MappingReplacement("E", null, null) },
			{ 'ē', new MappingReplacement("e", null, null) },
			{ 'Ģ', new MappingReplacement("G", null, null) },
			{ 'ģ', new MappingReplacement("g", null, null) },
			{ 'Ī', new MappingReplacement("I", null, null) },
			{ 'ī', new MappingReplacement("i", null, null) },
			{ 'Ķ', new MappingReplacement("K", null, null) },
			{ 'ķ', new MappingReplacement("k", null, null) },
			{ 'Ļ', new MappingReplacement("L", null, null) },
			{ 'ļ', new MappingReplacement("l", null, null) },
			{ 'Ņ', new MappingReplacement("N", null, null) },
			{ 'ņ', new MappingReplacement("n", null, null) },
			{ 'Š', new MappingReplacement("S", null, null) },
			{ 'š', new MappingReplacement("s", null, null) },
			{ 'Ū', new MappingReplacement("U", null, null) },
			{ 'ū', new MappingReplacement("u", null, null) },
			{ 'Ž', new MappingReplacement("Z", null, null) },
			{ 'ž', new MappingReplacement("z", null, null) }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}