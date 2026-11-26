namespace Diacritics.AccentMappings
{
    public partial class NorwegianAccentsMapping : IAccentMapping
    {
        static NorwegianAccentsMapping()
        {
            MappingDictionary.Add('Æ', "Ae");
            MappingDictionary.Add('æ', "ae");
            MappingDictionary.Add('Ø', "O");
            MappingDictionary.Add('ø', "o");
        }
    }
}