using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultipleInterfaceImplements.Repositories.Interface;

namespace MultipleInterfaceImplements.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        //Use an IEnumerable collection of service instances
        public AboutController(IEnumerable<ICustomLogger> loggers)
        {
            foreach(var logger in loggers) 
            {
                var objType = logger.GetType();
            }
        }
    }
    public delegate ICustomLogger ServiceResolver(ServiceType serviceType);
    //Use a delegate to retrieve a specific service instance
    public enum ServiceType
    {
        FileLogger,
        DbLogger,
        EventLogger
    }
}
