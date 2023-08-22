using Newtonsoft.Json;

namespace OBilet.API.Model.Request
{
    public class JourneyRequest
    {
        [JsonProperty("device-session")]
        public DeviceSessionRequest DeviceSession { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("data")]
        public DataRequest Data { get; set; }
    }
}