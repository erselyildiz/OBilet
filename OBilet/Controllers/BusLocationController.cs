using OBilet.API.Interface;
using OBilet.API.Model.Request;
using OBilet.API.Model.Response;
using OBilet.Attribute;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OBilet.Controllers
{
    [SessionAuthorize]
    public class BusLocationController : Controller
    {
        private readonly IBusLocationService _busLocationService;
        public BusLocationController(IBusLocationService busLocationService)
        {
            _busLocationService = busLocationService;
        }

        public async Task<JsonResult> GetBusLocation(string data = null)
        {
            SessionResponse sessionResponse = Session["OBiletSession"] as SessionResponse;
            BusLocationRequest busLocationRequest = new BusLocationRequest()
            {
                Data = data,
                DeviceSession = new DeviceSessionRequest
                {
                    DeviceId = sessionResponse.DeviceId,
                    SessionId = sessionResponse.SessionId
                },
                Date = System.DateTime.Now,
                Language = "tr-TR"
            };
            List<BusLocationResponse> busLocationResponses = await _busLocationService.GetBusLocation(busLocationRequest);
            busLocationResponses = busLocationResponses?.Take(5).ToList() ?? new List<BusLocationResponse>();
            return Json(busLocationResponses, JsonRequestBehavior.AllowGet);
        }
    }
}