using Newtonsoft.Json;

namespace OBilet.API.Model.Request
{
    public class SessionRequest
    {
        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("connection")]
        public ConnectionRequest Connection { get; set; }

        [JsonProperty("browser")]
        public BrowserRequest Browser { get; set; }
    }
}