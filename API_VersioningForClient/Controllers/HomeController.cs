using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//Pass version information in the URL
namespace API_VersioningForClient.Controllers
{
    //Use versions in the controller and action methods
    //[Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    //[ApiVersion("1.0")]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("1.1", Deprecated = true)]
    [ApiVersion("2.0")]
    public class HomeController : ControllerBase
    {
        string[] authors = new string[]
        { "Joydip Kanjilal", "Steve Smith", "Stephen Jones" };
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return authors;
        }
        //Map to a specific version of an action method
        [HttpGet("{id}")]
        [MapToApiVersion("2.0")]
        public string Get(int id)
        {
            return authors[id];
        }
    }
}
