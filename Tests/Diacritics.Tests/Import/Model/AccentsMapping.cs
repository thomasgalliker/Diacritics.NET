using System.Collections.Generic;
using Newtonsoft.Json;

namespace Diacritics.Tests.Import
{
    public class AccentsMapping
    {
        public Metadata Metadata { get; set; }

        [JsonConverter(typeof(AccentsMappingDataJsonConverter))]
        public List<AccentsMappingData> Data { get; set; }
    }
}
