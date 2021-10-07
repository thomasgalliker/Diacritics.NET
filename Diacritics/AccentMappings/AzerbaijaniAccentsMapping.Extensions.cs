namespace Diacritics.AccentMappings
{
    public partial class AzerbaijaniAccentsMapping : IAccentMapping
    {
        static AzerbaijaniAccentsMapping()
        {
            MappingDictionary.Add('Ə', new MappingReplacement("A", null, null));
            MappingDictionary.Add('ə', new MappingReplacement("a", null, null));
        }
    }
}