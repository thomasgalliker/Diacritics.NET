using System.Collections.Generic;
using Newtonsoft.Json;

namespace Diacritics.Tests.Import
{
    public class AccentsMapping
    {
        public AccentsMapping()
        {
            this.Data = new List<AccentsMappingData>();
        }

        [JsonProperty("metadata")]
        public Metadata? Metadata { get; set; }

        [JsonProperty("data")]
        [JsonConverter(typeof(AccentsMappingDataJsonConverter))]
        public List<AccentsMappingData> Data { get; set; }
    }
}
