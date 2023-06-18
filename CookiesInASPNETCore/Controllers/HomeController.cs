using CookiesInASPNETCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CookiesInASPNETCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor ? _httpContextAccessor;
        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            this._httpContextAccessor = httpContextAccessor;
        }
        //Write cookie data in your ASP.NET Core controller method
        public IActionResult Write(string key, string value, bool isPersistent)
        {
            CookieOptions options = new CookieOptions();
            if (isPersistent)
                options.Expires = DateTime.Now.AddDays(1);
            else
                options.Expires = DateTime.Now.AddSeconds(10);
            _httpContextAccessor.HttpContext.Response.Cookies.Append(key, value, options);

            return View("WriteCookie");
        }
        //Read cookie data in your ASP.NET Core controller method
        public IActionResult Read(string key)
        {
            ViewBag.Data = _httpContextAccessor.HttpContext.Request.Cookies[key];
            return View("ReadCookie");
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}