namespace Diacritics.AccentMappings
{
    public partial class TurkishAccentsMapping : IAccentMapping
    {
        static TurkishAccentsMapping()
        {
            // G with caron (U+01E6, U+01E7) is often used in place of G with breve (Ğ, ğ)
            MappingDictionary.Add('Ǧ', "G");
            MappingDictionary.Add('ǧ', "g");
        }
    }
}
