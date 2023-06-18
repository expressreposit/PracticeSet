using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace StateManagementCoreMVC.Controllers
{
    public class WelcomeController : Controller
    {
        //using Session State example.
        public IActionResult Index()
        {
            HttpContext.Session.SetString("Name", "John");
            HttpContext.Session.SetInt32("Age", 32);
            return View();
        }
        public IActionResult Get()
        {
            User? newUser = new User()
            {
                Name = HttpContext.Session.GetString("Name"),
                Age = 32
                //HttpContext.Session.GetInt32("Age").Value
            };
            return View(newUser);
        }
        public IActionResult GetQueryString(string name, int age)
        {
            User ? newUser = new User()
            {
                Name = name,
                Age = age
            };
            return View(newUser);
        }
    }
    public class User
    {
        public string? Name { get; set; } = string.Empty;
        public int? Age { get; set; } = 23;
    }
}
