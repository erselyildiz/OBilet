using Newtonsoft.Json;

namespace OBilet.API.Model.Request
{
    public class DeviceSessionRequest
    {
        [JsonProperty("session-id")]
        public string SessionId { get; set; }

        [JsonProperty("device-id")]
        public string DeviceId { get; set; }
    }
}