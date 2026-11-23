using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class OtherAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
            { 'Ė', "E" },
            { 'ė', "e" },
            { 'Ÿ', "Y" },
            { 'ÿ', "y" },
            { 'Ū', "U" },
            { 'ū', "u" },
            { 'Ī', "I" },
            { 'ī', "i" },
            { 'Į', "I" },
            { 'į', "i" },
            { 'Ø', "O" },
            { 'ø', "o" },
            { 'Ō', "O" },
            { 'ō', "o" },
            { 'Å', "A" },
            { 'å', "a" },
            { 'Ā', "A" },
            { 'ā', "a" },
            { 'Ǧ', "G" }, // U+01E6 Latin capital letter G with caron
            { 'ǧ', "g" }  // U+01E7 Latin small letter G with caron
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}
