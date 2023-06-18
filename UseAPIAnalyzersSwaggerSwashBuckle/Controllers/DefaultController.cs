using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UseAPIAnalyzersSwaggerSwashBuckle.Repository;

namespace UseAPIAnalyzersSwaggerSwashBuckle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class DefaultController : ControllerBase
    {
        AuthorRepository authorRepository = new AuthorRepository();
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
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
    }
}
