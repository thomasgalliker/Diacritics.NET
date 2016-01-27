using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class TurkishAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, char> MappingDictionary = new Dictionary<char, char>
                                                                                {
                                                                                    { 'ç', 'c' },
                                                                                    { 'é', 'e' },
                                                                                    { 'ë', 'e' },
                                                                                    { 'ğ', 'g' },
                                                                                    { 'İ', 'i' },
                                                                                    { 'ï', 'i' },
                                                                                    { 'ó', 'o' },
                                                                                    { 'ö', 'o' },
                                                                                    { 'ü', 'u' },
                                                                                };
        public IDictionary<char, char> Mapping { get { return MappingDictionary; } }
    }
}