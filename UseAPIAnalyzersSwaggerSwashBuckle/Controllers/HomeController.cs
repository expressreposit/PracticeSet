using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UseAPIAnalyzersSwaggerSwashBuckle.Models;
using UseAPIAnalyzersSwaggerSwashBuckle.Repository;

namespace UseAPIAnalyzersSwaggerSwashBuckle.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        AuthorRepository authorRepository = new AuthorRepository();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Author>> Get(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            try
            {
                var author = await authorRepository.GetAuthor(id);
                if (author == null)
                    return NotFound();
                return Ok(author);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut]
        public async Task<ActionResult<bool>> Put([FromBody] Author author)
        {
            var result = await authorRepository.GetAuthor(author.Id);
            if (result == null)
                return NotFound();
            if (author == null)
            {
                return BadRequest();
            }
            try
            {
                var success = await authorRepository.SaveAuthor(author);
                if (!success)
                    return BadRequest();
                return Ok(author);
            }
            catch
            {
                return BadRequest();
            }
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