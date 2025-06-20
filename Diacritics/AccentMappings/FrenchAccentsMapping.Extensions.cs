namespace Diacritics.AccentMappings
{
    public partial class FrenchAccentsMapping : IAccentMapping
    {
        static FrenchAccentsMapping()
        {
            MappingDictionary.Add('̧', "");
            MappingDictionary.Add('æ', "ae");
            MappingDictionary.Add('œ', "oe");
        }
    }
}