using Newtonsoft.Json;

namespace OBilet.API.Model.Request
{
    public class BrowserRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}