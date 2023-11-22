using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Core.IRepositories;
using RepositoryPattern.Core.Models;

namespace RepositoryPattern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IGenericRepository<Book> BookRepository;

        public BookController(IGenericRepository<Book> BookRepository)
        {
            this.BookRepository = BookRepository;
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            if(BookRepository.GetById(id)==null)
                return NotFound();
            else
            return Ok(BookRepository.GetById(id));
        }
    }
}
