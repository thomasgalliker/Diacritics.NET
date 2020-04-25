using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class VietnameseAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
            { 'Ờ', "o" },
            { 'ờ', "o" },
            { 'Ớ', "o" },
            { 'ớ', "o" },
            { 'Ở', "o" },
            { 'ở', "o" },
            { 'Ỡ', "o" },
            { 'ỡ', "o" },
            { 'Ợ', "o" },
            { 'ợ', "o" },
        };
        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}
