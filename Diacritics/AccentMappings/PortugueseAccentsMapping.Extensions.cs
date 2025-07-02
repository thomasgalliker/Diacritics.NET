namespace Diacritics.AccentMappings
{
    public partial class PortugueseAccentsMapping : IAccentMapping
    {
        static PortugueseAccentsMapping()
        {
            MappingDictionary.Add('ª', "a");
            MappingDictionary.Add('º', "o");
        }
    }
}