
using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public interface IAccentMapping
    {
        IDictionary<char, MappingReplacement> Mapping { get; }
    }
}
