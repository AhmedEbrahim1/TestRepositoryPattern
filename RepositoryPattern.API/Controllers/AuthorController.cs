using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Core.IRepositories;
using RepositoryPattern.Core.Models;

namespace RepositoryPattern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IGenericRepository<Author> authorRepository;

        public AuthorController(IGenericRepository<Author> authorRepository)
        {
            this.authorRepository = authorRepository;
        }


        [HttpGet]
        public IActionResult GetById(int id)
        {
            if (authorRepository.GetById(id)==null)
                return NotFound();  
            else
            return Ok(authorRepository.GetById(id));
        }
    }
}
