
using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public interface IAccentMapping
    {
        Dictionary<char, char> GetMapping();
    }
}
