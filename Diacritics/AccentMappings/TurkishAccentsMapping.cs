using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class TurkishAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
                                                                                {
                                                                                    { 'ç', "c" },
                                                                                    { 'é', "e" },
                                                                                    { 'ë', "e" },
                                                                                    { 'ğ', "g" },
                                                                                    { 'İ', "i" },
                                                                                    { 'ï', "i" },
                                                                                    { 'ı', "i" },
                                                                                    { 'ó', "o" },
                                                                                    { 'ö', "o" },
                                                                                    { 'ü', "u" },
                                                                                };
        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}