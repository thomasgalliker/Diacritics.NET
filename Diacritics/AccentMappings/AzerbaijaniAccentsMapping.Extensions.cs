namespace Diacritics.AccentMappings
{
    public partial class AzerbaijaniAccentsMapping : IAccentMapping
    {
        static AzerbaijaniAccentsMapping()
        {
            MappingDictionary.Add('Ə', new MappingReplacement("A", "", ""));
            MappingDictionary.Add('ə', new MappingReplacement("a", "", ""));
        }
    }
}