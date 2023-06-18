using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultipleInterfaceImplements.Repositories.Interface;

namespace MultipleInterfaceImplements.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        //Use dependency injection and resolve the service instance
        public AccountController(Func<ServiceType, ICustomLogger> serviceResolver)
        {
            var service = serviceResolver(ServiceType.FileLogger);
        }
    }
}
