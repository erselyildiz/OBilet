using OBilet.Attribute;
using System.Web.Mvc;

namespace OBilet.Controllers
{
    [SessionAuthorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}