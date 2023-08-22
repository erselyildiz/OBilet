using OBilet.API.Model.Request;
using OBilet.API.Model.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OBilet.API.Interface
{
    public interface IJourneyService
    {
        Task<List<JourneyRootResponse>> GetJourney(JourneyRequest journeyRequest);
    }
}