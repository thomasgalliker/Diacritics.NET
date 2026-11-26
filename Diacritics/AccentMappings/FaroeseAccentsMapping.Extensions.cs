namespace Diacritics.AccentMappings
{
    public partial class FaroeseAccentsMapping : IAccentMapping
    {
        static FaroeseAccentsMapping()
        {
            MappingDictionary.Add('Æ', "Ae");
            MappingDictionary.Add('æ', "ae");
            MappingDictionary.Add('Ø', "O");
            MappingDictionary.Add('ø', "o");
            MappingDictionary.Add('Ð', "D");
            MappingDictionary.Add('ð', "d");
        }
    }
}