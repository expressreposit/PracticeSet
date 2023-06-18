using GlobalExceptionHandlingMVC.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GlobalExceptionHandlingMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet("/Error")]
        public IActionResult Index()
        {
            IExceptionHandlerPathFeature iExceptionHandlerFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            if (iExceptionHandlerFeature != null)
            {
                string path = iExceptionHandlerFeature.Path;
                Exception exception = iExceptionHandlerFeature.Error;
                //Write code here to log the exception details
                return View("Error", iExceptionHandlerFeature);
            }
            return View();
        }
        [HttpGet("/Error/NotFound/{statusCode}")]
        public IActionResult NotFound(int statusCode)
        {
            var iStatusCodeReExecuteFeature = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            return View("NotFound", iStatusCodeReExecuteFeature.OriginalPath);
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