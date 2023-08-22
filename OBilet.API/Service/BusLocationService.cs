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
    public class BusLocationService : IBusLocationService
    {
        public async Task<List<BusLocationResponse>> GetBusLocation(BusLocationRequest busLocationRequest)
        {
            RestClient client = new RestClient("https://v2-api.obilet.com/api/location/getbuslocations");

            RestRequest request = new RestRequest("sesion");

            request.AddHeader("Authorization", "Basic JEcYcEMyantZV095WVc3G2JtVjNZbWx1");

            request.AddParameter("application/json", JsonConvert.SerializeObject(busLocationRequest), ParameterType.RequestBody);

            RestResponse result = await client.ExecutePostAsync(request);

            APIResponse<List<BusLocationResponse>> pushRequest = result.Content.StringToJsonConvert<APIResponse<List<BusLocationResponse>>>();

            return pushRequest.Data;
        }
    }
}