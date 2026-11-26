namespace Diacritics.AccentMappings
{
    public partial class DanishAccentsMapping : IAccentMapping
    {
        static DanishAccentsMapping()
        {
            MappingDictionary.Add('Æ', "Ae");
            MappingDictionary.Add('æ', "ae");
            MappingDictionary.Add('Ø', "O");
            MappingDictionary.Add('ø', "o");
        }
    }
}