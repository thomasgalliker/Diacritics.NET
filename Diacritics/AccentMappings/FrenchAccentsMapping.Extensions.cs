namespace Diacritics.AccentMappings
{
    public partial class FrenchAccentsMapping : IAccentMapping
    {
        static FrenchAccentsMapping()
        {
            MappingDictionary.Add('̧', "");
            MappingDictionary.Add('Æ', "Ae");
            MappingDictionary.Add('æ', "ae");
            MappingDictionary.Add('Œ', "Oe");
            MappingDictionary.Add('œ', "oe");
        }
    }
}