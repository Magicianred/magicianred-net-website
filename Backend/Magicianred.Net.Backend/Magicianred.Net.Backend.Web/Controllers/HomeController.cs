using System.Web.Mvc;

namespace Magicianred.Net.Backend.Web.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return Redirect(Url.Content("~/index.html"));
            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}