using System.Collections.Generic;
using Newtonsoft.Json;

namespace Diacritics.Tests.Import
{
    public class Metadata
    {
        public Metadata()
        {
            this.Continents = new List<string>();
        }

        [JsonProperty("alphabet")]
        public string? Alphabet { get; set; }

        [JsonProperty("continent")]
        public ICollection<string> Continents { get; set; }

        [JsonProperty("language")]
        public string? Language { get; set; }

        [JsonProperty("languageNative")]
        public string? LanguageNative { get; set; }
    }
}
