namespace Diacritics.AccentMappings
{
    public partial class PortugueseAccentsMapping : IAccentMapping
    {
        static PortugueseAccentsMapping()
        {
            MappingDictionary.Add('ª', new MappingReplacement("a", null, null));
            MappingDictionary.Add('º', new MappingReplacement("o", null, null));
        }
    }
}