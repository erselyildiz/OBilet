using Newtonsoft.Json;

namespace OBilet.API.Extension
{
    public static class StringToJsonConvertExtension
    {
        public static T StringToJsonConvert<T>(this string str)
        {
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };

            return JsonConvert.DeserializeObject<T>(str, settings);
        }
    }
}
