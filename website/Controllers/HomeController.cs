using System.Web.Mvc;

namespace website.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("overview")]
        public ActionResult Overview()
        {
            return View();
        }

    }
}