using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class TonganAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
			{ 'á', "a" },
			{ 'é', "e" },
			{ 'í', "i" },
			{ 'ó', "o" },
			{ 'ú', "u" },
			{ 'ā', "a" },
			{ 'ē', "e" },
			{ 'ī', "i" },
			{ 'ō', "o" },
			{ 'ū', "u" }
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}