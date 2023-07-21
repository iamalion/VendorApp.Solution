using Microsoft.AspNetCore.Mvc;
using VendorApp.Models;

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