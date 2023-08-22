using OBilet.API.Interface;
using OBilet.API.Model.Request;
using OBilet.API.Model.Response;
using OBilet.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OBilet.Controllers
{
    [SessionAuthorize]
    public class JourneyController : Controller
    {
        private readonly IJourneyService _journeyService;
        public JourneyController(IJourneyService journeyService)
        {
            _journeyService = journeyService;
        }

        public async Task<ActionResult> GetJourney(int originId, int destinationId, DateTime date)
        {
            SessionResponse sessionResponse = Session["OBiletSession"] as SessionResponse;
            JourneyRequest journeyRequest = new JourneyRequest()
            {
                Data = new DataRequest
                {
                    OriginId = originId,
                    DestinationId = destinationId,
                    DepartureDate = date.ToString("yyyy-MM-dd")
                },
                DeviceSession = new DeviceSessionRequest
                {
                    DeviceId = sessionResponse.DeviceId,
                    SessionId = sessionResponse.SessionId
                },
                Date = date.ToString("yyyy-MM-dd"),
                Language = "tr-TR"
            };
            List<JourneyRootResponse> journeyResponses = await _journeyService.GetJourney(journeyRequest);
            journeyResponses = journeyResponses?.Take(6).ToList() ?? new List<JourneyRootResponse>();
            return View(journeyResponses);
        }
    }
}