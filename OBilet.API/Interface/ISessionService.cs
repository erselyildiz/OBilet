using OBilet.API.Model.Request;
using OBilet.API.Model.Response;

namespace OBilet.API.Interface
{
    public interface ISessionService
    {
        SessionResponse GetSession(SessionRequest sessionRequest);
    }
}