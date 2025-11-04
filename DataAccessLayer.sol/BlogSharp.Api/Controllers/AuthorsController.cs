using DataAccess.Interface;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace BlogSharp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorsController : ControllerBase
    {
        IAuthorDao _autherDao;
        public AuthorsController(IAuthorDao authorDao) =>
            _autherDao = authorDao;

        [HttpGet]
        public ActionResult<IEnumerable<Author>> Get()
        {
            try
            {
                return Ok(_autherDao.GetAll());
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Could not get authors");
            }


        }
    }
}

