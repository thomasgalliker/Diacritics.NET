namespace Diacritics.AccentMappings
{
    public partial class FrenchAccentsMapping : IAccentMapping
    {
        static FrenchAccentsMapping()
        {
            MappingDictionary.Add('̧', new MappingReplacement("", null, null));
            MappingDictionary.Add('æ', new MappingReplacement("ae", null, null));
            MappingDictionary.Add('œ', new MappingReplacement("oe", null, null));
        }
    }
}