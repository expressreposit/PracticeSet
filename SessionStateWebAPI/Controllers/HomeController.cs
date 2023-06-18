using Microsoft.AspNetCore.Mvc;

namespace SessionStateWebAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("Message", "Hello World!");
            HttpContext.Session.SetInt32("Year", 2019);
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Message = HttpContext.Session.GetString("Message");
            ViewBag.Year = HttpContext.Session.GetInt32("Year");
            return View();
        }
    }
}
