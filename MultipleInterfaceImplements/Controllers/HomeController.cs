using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultipleInterfaceImplements.Repositories.Interface;

namespace MultipleInterfaceImplements.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        //When you run this application and the breakpoint is hit,
        //you’ll observe that all three parameters are instances of type
        //EventLogger because EventLogger has been injected last. 
        public HomeController(ICustomLogger fileLogger, ICustomLogger dbLogger, ICustomLogger eventLogger)
        {
            var obj = fileLogger;
        }
    }
}
