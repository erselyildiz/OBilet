using OBilet.API.Model.Request;
using OBilet.API.Model.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OBilet.API.Interface
{
    public interface IBusLocationService
    {
        Task<List<BusLocationResponse>> GetBusLocation(BusLocationRequest busLocationRequest);
    }
}