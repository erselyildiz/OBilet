using Newtonsoft.Json;
using System;

namespace OBilet.API.Model.Request
{
    public class BusLocationRequest
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("device-session")]
        public DeviceSessionRequest DeviceSession { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }
}