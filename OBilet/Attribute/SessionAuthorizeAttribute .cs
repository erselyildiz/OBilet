using OBilet.API.Model.Request;
using OBilet.API.Service;
using System.Web;
using System.Web.Mvc;

namespace OBilet.Attribute
{
    public class SessionAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            return httpContext.Session["OBiletSession"] != null;
        }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            SessionRequest sessionRequest = new SessionRequest
            {
                Type = 1,
                Connection = new ConnectionRequest
                {
                    IpAddress = "165.114.41.21",
                    Port = "5117"
                },
                Browser = new BrowserRequest
                {
                    Name = "Chrome",
                    Version = "47.0.0.12"
                }
            };

            SessionService sessionService = new SessionService();

            filterContext.HttpContext.Session["OBiletSession"] = sessionService.GetSession(sessionRequest);
        }
    }
}