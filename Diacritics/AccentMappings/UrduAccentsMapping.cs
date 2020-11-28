using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class UrduAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
			{ 'آ', "ا" },
			{ 'أ', "ا" },
			{ 'ؤ', "و" },
			{ 'ئ', "ي" },
			{ 'ۂ', "ہ" }
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}