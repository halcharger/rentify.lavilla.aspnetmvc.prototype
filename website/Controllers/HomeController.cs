using System.Web.Mvc;

namespace website.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult home()
        {
            return View();
        }

        [Route("overview")]
        public ActionResult overview()
        {
            return View();
        }

        [Route("gallery")]
        public ActionResult gallery()
        {
            return View();
        }

        [Route("rates")]
        public ActionResult rates()
        {
            return View();
        }

        [Route("availability")]
        public ActionResult availability()
        {
            return View();
        }

        [Route("reviews")]
        public ActionResult reviews()
        {
            return View();
        }

        [Route("contact")]
        public ActionResult contact()
        {
            return View();
        }

        [Route("booking")]
        public ActionResult booking()
        {
            return View();
        }


        [Route("pay")]
        public ActionResult pay()
        {
            return View();
        }

    }
}