using Newtonsoft.Json;
using System;

namespace OBilet.API.Model.Response
{
    public class StopResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("kolayCarLocationId")]
        public int? KolayCarLocationId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("station")]
        public string Station { get; set; }

        [JsonProperty("time")]
        public DateTime Time { get; set; }

        [JsonProperty("is-origin")]
        public bool IsOrigin { get; set; }

        [JsonProperty("is-destination")]
        public bool IsDestination { get; set; }
    }
}