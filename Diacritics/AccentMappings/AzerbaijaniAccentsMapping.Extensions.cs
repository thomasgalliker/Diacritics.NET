namespace Diacritics.AccentMappings
{
    public partial class AzerbaijaniAccentsMapping : IAccentMapping
    {
        static AzerbaijaniAccentsMapping()
        {
            MappingDictionary.Add('Ə', "A");
            MappingDictionary.Add('ə', "a");
        }
    }
}