using Newtonsoft.Json;
using OBilet.API.Interface;
using OBilet.API.Model.Request;
using OBilet.API.Model.Response;
using RestSharp;

namespace OBilet.API.Service
{
    public class SessionService : ISessionService
    {
        public SessionResponse GetSession(SessionRequest sessionRequest)
        {
            RestClient client = new RestClient("https://v2-api.obilet.com/api/client/getsession");

            RestRequest request = new RestRequest("sesion");

            request.AddHeader("Authorization", "Basic JEcYcEMyantZV095WVc3G2JtVjNZbWx1");

            request.AddParameter("application/json", JsonConvert.SerializeObject(sessionRequest), ParameterType.RequestBody);

            RestResponse result = client.ExecutePost(request);

            APIResponse<SessionResponse> pushRequest = JsonConvert.DeserializeObject<APIResponse<SessionResponse>>(result.Content);

            return pushRequest.Data;
        }
    }
}