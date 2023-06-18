using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UseProblemdetailsMiddleware.Models;

namespace UseProblemdetailsMiddleware.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //Use ProblemDetails in action methods in ASP.NET Core
        [HttpGet("{x}")]
        public ActionResult Get(int x)
        {
            int i = 0;
            try
            {
                i = 10 / x;
            }
            catch (Exception ex)
            {
                var problemDetails = new Microsoft.AspNetCore.Mvc.ProblemDetails
                {
                    Status = StatusCodes.Status403Forbidden,
                    Type = "https://example.com/probs/out-of-credit",
                    Title = "Division by zero...",
                    Detail = ex.StackTrace,
                    Instance = HttpContext.Request.Path
                };
                return BadRequest(problemDetails);
            }
            return Ok(i);
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