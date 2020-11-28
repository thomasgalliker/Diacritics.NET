using System.Collections.Generic;
using Newtonsoft.Json;

namespace Diacritics.Tests.Import
{
    public class Metadata
    {
        public string Alphabet { get; set; }

        [JsonProperty("continent")]
        public ICollection<string> Continents { get; set; }

        public string Language { get; set; }

        public string LanguageNative { get; set; }
    }
}
