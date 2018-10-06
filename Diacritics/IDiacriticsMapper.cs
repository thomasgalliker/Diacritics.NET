using System.Collections.Generic;

namespace Diacritics
{
    public interface IDiacriticsMapper : IEnumerable<KeyValuePair<char, string>>
    {
        string RemoveDiacritics(string source);

        bool HasDiacritics(string source);
    }
}