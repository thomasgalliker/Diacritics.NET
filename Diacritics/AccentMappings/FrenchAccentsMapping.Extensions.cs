namespace Diacritics.AccentMappings
{
    public partial class FrenchAccentsMapping : IAccentMapping
    {
        static FrenchAccentsMapping()
        {
            MappingDictionary.Add('̧', new MappingReplacement("", "", ""));
            MappingDictionary.Add('æ', new MappingReplacement("ae", "", ""));
            MappingDictionary.Add('œ', new MappingReplacement("oe", "", ""));
        }
    }
}