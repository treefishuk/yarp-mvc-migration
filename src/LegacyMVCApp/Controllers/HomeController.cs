using System.Web.Mvc;

namespace LegacyMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }
        public ActionResult Index()
        {
            return View();
        }       
    }
}