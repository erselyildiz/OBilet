using Newtonsoft.Json;

namespace OBilet.API.Model.Request
{
    public class ConnectionRequest
    {
        [JsonProperty("ip-address")]
        public string IpAddress { get; set; }

        [JsonProperty("port")]
        public string Port { get; set; }
    }
}