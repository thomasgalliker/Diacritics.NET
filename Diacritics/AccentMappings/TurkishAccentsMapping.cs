using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class TurkishAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
            { 'â', "a" },
            { 'ç', "c" },
            { 'é', "e" },
            { 'ë', "e" },
            { 'ğ', "g" },
            { 'î', "i" },
            { 'İ', "i" },
            { 'ï', "i" },
            { 'ı', "i" },
            { 'ó', "o" },
            { 'ö', "o" },
            { 'û', "u" },
            { 'ü', "u" },
            { 'ş', "s" },
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}