using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UseDependencyInjectionInActionFiltersMVC.Filters;
using UseDependencyInjectionInActionFiltersMVC.Models;

namespace UseDependencyInjectionInActionFiltersMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //Use a custom action filter in the controller in
        [ServiceFilter(typeof(CustomActionFilter),Order =2)]
        public IEnumerable<string> Get()
        {
            _logger.LogInformation("Inside HttpGet action method...");
            return new string[] { "Joydip", "Michael", "Anand", "Steve" };
        }
        [TypeFilter(typeof(CustomActionFilter), Arguments = new object[] { "This is a string parameter" })]
        [HttpGet("")]
        public IEnumerable<string> Get1()
        {
            _logger.LogInformation("Inside HttpGet action method...");
            return new string[] { "Joydip", "Michael", "Anand", "Steve" };
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