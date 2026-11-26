namespace Diacritics.AccentMappings
{
    public partial class VietnameseAccentsMapping : IAccentMapping
    {
        static VietnameseAccentsMapping()
        {
            MappingDictionary.Add('Đ', "D");
            MappingDictionary.Add('đ', "d");
        }
    }
}
