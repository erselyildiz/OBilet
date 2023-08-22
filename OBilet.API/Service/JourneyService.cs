using Newtonsoft.Json;
using OBilet.API.Extension;
using OBilet.API.Interface;
using OBilet.API.Model.Request;
using OBilet.API.Model.Response;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OBilet.API.Service
{
    public class JourneyService : IJourneyService
    {
        public async Task<List<JourneyRootResponse>> GetJourney(JourneyRequest journeyRequest)
        {
            RestClient client = new RestClient("https://v2-api.obilet.com/api/journey/getbusjourneys");

            RestRequest request = new RestRequest("sesion");

            request.AddHeader("Authorization", "Basic JEcYcEMyantZV095WVc3G2JtVjNZbWx1");

            request.AddParameter("application/json", JsonConvert.SerializeObject(journeyRequest), ParameterType.RequestBody);

            RestResponse result = await client.ExecutePostAsync(request);
            APIResponse<List<JourneyRootResponse>> pushRequest = result.Content.StringToJsonConvert<APIResponse<List<JourneyRootResponse>>>();

            return pushRequest.Data;
        }
    }
}