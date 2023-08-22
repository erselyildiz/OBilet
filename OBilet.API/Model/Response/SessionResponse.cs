using Newtonsoft.Json;

namespace OBilet.API.Model.Response
{
    public class SessionResponse
    {
        [JsonProperty("session-id")]
        public string SessionId { get; set; }

        [JsonProperty("device-id")]
        public string DeviceId { get; set; }
        public object Affiliate { get; set; }

        [JsonProperty("device-type")]
        public int DeviceType { get; set; }
        public object Device { get; set; }

        [JsonProperty("ip-country")]
        public string IpCountry { get; set; }
    }
}