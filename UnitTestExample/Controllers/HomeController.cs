using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UnitTestExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        //This is a unit of work and Unit test means Test our development.
        public string Index()
        {
            return "I am in home";
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
