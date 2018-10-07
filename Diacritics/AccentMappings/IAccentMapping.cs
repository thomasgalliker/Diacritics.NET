
using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public interface IAccentMapping
    {
        IDictionary<char, string> Mapping { get; }
    }
}
