using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;

namespace BlogSharp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorsController : ControllerBase
    {
        public AuthorsController()
        {

        }

        [HttpGet]
        public IEnumerable<Author> Get()
        {

        }
    }
}
