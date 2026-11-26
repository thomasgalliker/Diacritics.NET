namespace Diacritics.AccentMappings
{
    public partial class ArabicAccentsMapping : IAccentMapping
    {
        static ArabicAccentsMapping()
        {
            // Harakat (short vowel marks, tanwin, shadda, sukun) and superscript alef are removed.
            // The diacritics database lists them as letter + mark sequences (e.g. "ب\u064E" -> "ب"),
            // which cannot be represented as single char mappings.
            MappingDictionary.Add('\u064B', ""); // ARABIC FATHATAN
            MappingDictionary.Add('\u064C', ""); // ARABIC DAMMATAN
            MappingDictionary.Add('\u064D', ""); // ARABIC KASRATAN
            MappingDictionary.Add('\u064E', ""); // ARABIC FATHA
            MappingDictionary.Add('\u064F', ""); // ARABIC DAMMA
            MappingDictionary.Add('\u0650', ""); // ARABIC KASRA
            MappingDictionary.Add('\u0651', ""); // ARABIC SHADDA
            MappingDictionary.Add('\u0652', ""); // ARABIC SUKUN
            MappingDictionary.Add('\u0670', ""); // ARABIC LETTER SUPERSCRIPT ALEF
        }
    }
}