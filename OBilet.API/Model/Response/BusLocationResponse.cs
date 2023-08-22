using Newtonsoft.Json;

namespace OBilet.API.Model.Response
{
    public class BusLocationResponse
    {
        public int Id { get; set; }

        [JsonProperty("parent-Id")]
        public int ParentId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }

        [JsonProperty("geo-location")]
        public GeoLocationResponse GeoLocation { get; set; }
        public int Zoom { get; set; }

        [JsonProperty("tz-Code")]
        public string TzCode { get; set; }

        //[JsonProperty("weather-Code")]
        //public string WeatherCode { get; set; }
        public int Rank { get; set; }

        //[JsonProperty("reference-Code")]
        //public string ReferenceCode { get; set; }

        [JsonProperty("city-Id")]
        public int CityId { get; set; }

        //[JsonProperty("reference-country")]
        //public string ReferenceCountry { get; set; }

        [JsonProperty("country-Id")]
        public int CountryId { get; set; }
        public string Keywords { get; set; }

        [JsonProperty("city-name")]
        public string CityName { get; set; }
        //public string Languages { get; set; }

        [JsonProperty("country-name")]
        public string CountryName { get; set; }

        //[JsonProperty("area-Code")]
        //public string AreaCode { get; set; }

        [JsonProperty("show-country")]
        public bool ShowCountry { get; set; }
        //public string Code { get; set; }

        [JsonProperty("is-city-center")]
        public bool IsCityCenter { get; set; }

        [JsonProperty("long-name")]
        public string LongName { get; set; }
    }
}