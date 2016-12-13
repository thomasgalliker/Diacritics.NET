using System.Collections.Generic;

namespace Diacritics
{
    public interface IDiacriticsMapper : IEnumerable<KeyValuePair<char, char>>
    {
        string RemoveDiacritics(string source);

        bool HasDiacritics(string source);
    }
}