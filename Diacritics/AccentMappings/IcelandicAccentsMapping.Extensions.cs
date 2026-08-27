namespace Diacritics.AccentMappings
{
    public partial class IcelandicAccentsMapping : IAccentMapping
    {
        static IcelandicAccentsMapping()
        {
            MappingDictionary.Add('þ', "th");
            MappingDictionary.Add('Þ', "Th");
            MappingDictionary.Add('ð', "d");
            MappingDictionary.Add('Ð', "D");
            MappingDictionary.Add('æ', "ae");
            MappingDictionary.Add('Æ', "Ae");
        }
    }
}
