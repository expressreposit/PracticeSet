using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace XUnitTestExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public string Index()
        {
            return "I am in Home";
        }
        [HttpGet("Index/{guessedNumber}")]
        public string Index(int guessedNumber)
        {
            if (guessedNumber < 100)
            {
                return "Wrong! try a bigger number";
            }
            else if (guessedNumber > 100)
            {
                return "Wrong! try a smaller number";
            }
            else
                return "You guessed correct number";
        }
    }
}
