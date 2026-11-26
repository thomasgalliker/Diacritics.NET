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

            // Letters with stroke, bar or hook (no canonical Unicode decomposition)
            { 'ƀ', "b" },
            { 'Ɓ', "B" },
            { 'ɓ', "b" },
            { 'Ɖ', "D" },
            { 'ɖ', "d" },
            { 'Ɗ', "D" },
            { 'ɗ', "d" },
            { 'Ǥ', "G" },
            { 'ǥ', "g" },
            { 'Ħ', "H" },
            { 'ħ', "h" },
            { 'Ɨ', "I" },
            { 'ɨ', "i" },
            { 'Ƙ', "K" },
            { 'ƙ', "k" },
            { 'Ŀ', "L" },
            { 'ŀ', "l" },
            { 'Ŧ', "T" },
            { 'ŧ', "t" },
            { 'Ƴ', "Y" },
            { 'ƴ', "y" },
            { 'Ƶ', "Z" },
            { 'ƶ', "z" },

            // Digraphs and ligatures
            { 'Ĳ', "IJ" },
            { 'ĳ', "ij" },
            { 'Ǆ', "DZ" },
            { 'ǅ', "Dz" },
            { 'ǆ', "dz" },
            { 'Ǉ', "LJ" },
            { 'ǈ', "Lj" },
            { 'ǉ', "lj" },
            { 'Ǌ', "NJ" },
            { 'ǋ', "Nj" },
            { 'ǌ', "nj" },
            { 'Ǳ', "DZ" },
            { 'ǲ', "Dz" },
            { 'ǳ', "dz" },
            { 'ﬀ', "ff" },
            { 'ﬁ', "fi" },
            { 'ﬂ', "fl" },
            { 'ﬃ', "ffi" },
            { 'ﬄ', "ffl" },
            { 'ﬅ', "st" },
            { 'ﬆ', "st" },

            // Other letters
            { 'ŉ', "'n" },
            { 'ſ', "s" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}
