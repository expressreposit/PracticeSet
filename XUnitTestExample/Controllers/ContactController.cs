using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XUnitTestExample.Models;

namespace XUnitTestExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private  IPrinterService _printerService;
        private  IEmailService _emailService;
        public ContactController(IPrinterService printerService, IEmailService emailService)
        {
            _printerService = printerService;
            _emailService = emailService;
        }

        [HttpGet("Index/{guessedNumber}")]
        public string Index(int guessedNumber)
        {
            string result;
            if (guessedNumber < 100)
            {
                result= "Wrong! try a bigger number";
            }
            else if (guessedNumber > 100)
            {
                result = "Wrong! try a smaller number";
            }
            else
            {
                result = "You guessed correct number";
            }
            if (_emailService.isEmailAvailable())
            {
                _emailService.SendEmail();
            }
            if (_printerService.isPrintAvailable())
            {
                _printerService.Print("Test with string parameter in method");
            }
            return result;
        }
    }
}
