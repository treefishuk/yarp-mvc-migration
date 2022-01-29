using LegacyMVCAPP.Auth;
using System.Web.Mvc;

namespace LegacyMVCApp.Controllers
{
    public class LegacyController : Controller
    {
        public LegacyController()
        {
        }
        public ActionResult About()
        {

            //HttpContext.Request.Cookies.

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [Authorize]
        public ActionResult Protected()
        {
            return View();
        }
    }
}