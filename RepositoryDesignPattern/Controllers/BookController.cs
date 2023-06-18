using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryDesignPattern.Entities;
using RepositoryDesignPattern.Repositories.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace RepositoryDesignPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _bookRepository.Get();
        }
    }
}
