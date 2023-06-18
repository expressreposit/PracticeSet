using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IHttpClientFactoryExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        //Inject an IHttpClientFactory instance to your controllers in ASP.NET Core
        private IHttpClientFactory _httpClientFactory;
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger,IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }
        //Call your action methods using HttpClient in ASP.NET Core
        //public async Task<IActionResult> Index()
        //{
        //    HttpClient httpClient = _httpClientFactory.CreateClient();
        //    httpClient.BaseAddress = new Uri("http://localhost:1810/");
        //    var response = await httpClient.GetAsync("/api/values");
        //    string str = await response.Content.ReadAsStringAsync();
        //    List<string> data = JsonSerializer.Deserialize<List<string>>(str);
        //    return ViewResult(data);
        //}
    }
}
