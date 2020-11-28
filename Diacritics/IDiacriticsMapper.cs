using System.Collections.Generic;

namespace Diacritics
{
    public interface IDiacriticsMapper : IEnumerable<KeyValuePair<char, MappingReplacement>>
    {
        string RemoveDiacritics(string source, DiacriticsOptions options = null);

        bool HasDiacritics(string source, DiacriticsOptions options = null);
    }
}