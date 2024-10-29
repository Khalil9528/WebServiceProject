using Microsoft.AspNetCore.Mvc;
using WebServiceProject.Data;
using WebServiceProject.Intefraces;
using WebServiceProject.Models;
using WebServiceProject.Repository;

namespace WebServiceProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly DataContext _context;
        public UserController(IUserRepository userRepository, DataContext context)
        {
            _userRepository = userRepository;
            _context = context; 
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<User>))]

        public IActionResult GetUsers()
        {
            var Users = _userRepository.GetUsers();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(Users);
        }

    }
}
