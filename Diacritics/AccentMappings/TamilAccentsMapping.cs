using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class TamilAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
			{ 'ஔ', "ஒ" }
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}