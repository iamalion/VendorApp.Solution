using Microsoft.AspNetCore.Mvc;

namespace VendorApp.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}