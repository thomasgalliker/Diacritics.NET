using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class ArabicAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, char> MappingDictionary = new Dictionary<char, char>
        {
            { 'أ', 'ا' },
            { 'إ', 'ا' },
            { 'آ', 'ا' },
            { 'ء', 'ا' },
            { 'پ', 'ب' },
            { 'ض', 'ص' },
            { 'ذ', 'د' },
            { 'ـ', 'ّ' },
            { 'خ', 'ح' },
            { 'غ', 'ع' },
            { 'ش', 'س' },
            { 'ة', 'ت' },
            { 'ث', 'ت' },
            { 'ً', 'َ' },
            { 'ٰ', 'َ' },
            { 'ؤ', 'و' },
            { 'ظ', 'ط' },
            { 'ى', 'ي' },
            { 'ئ', 'ي' },
        };

        public IDictionary<char, char> Mapping { get { return MappingDictionary; } }
    }
}