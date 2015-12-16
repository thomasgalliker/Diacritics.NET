
namespace Diacritics.AccentMappings
{
    public class ArabicAccentsMapping : AccentMapping
    {
        private static readonly char[] ArabicAccents = { 'أ', 'إ', 'آ', 'ء', 'پ', 'ض', 'ذ', 'ـ', 'خ', 'خ', 'غ', 'ش', 'ة', 'ث', 'ً', 'ٰ', 'ؤ', 'ظ', 'ى', 'ئ' };

        private static readonly char[] ArabicReplace = { 'ا', 'ا', 'ا', 'ا', 'ب', 'ص', 'د', 'ّ', 'ح', 'ك', 'ع', 'س', 'ت', 'ت', 'َ', 'َ', 'و', 'ط', 'ي', 'ي' };

        protected override char[] GetCharacters()
        {
            return ArabicAccents;
        }

        protected override char[] GetReplacements()
        {
            return ArabicReplace;
        }
    }
}