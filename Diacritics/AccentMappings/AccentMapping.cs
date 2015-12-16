using System.Collections.Generic;
using System.Linq;

namespace Diacritics.AccentMappings
{
    public abstract class AccentMapping : IAccentMapping
    {
        public Dictionary<char, char> GetMapping()
        {
             return this.GetCharacters().Zip(this.GetReplacements(), (k, v) => new { k, v }).GroupBy(x => x.k).ToDictionary(x => x.Key, x => x.First().v);
        }

        protected abstract char[] GetCharacters();

        protected abstract char[] GetReplacements();
    }
}