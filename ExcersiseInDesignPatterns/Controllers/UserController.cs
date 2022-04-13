using ExcersiseInDesignPatterns.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExcersiseInDesignPatterns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserStorage _userStorage;

        public UserController(IUserStorage userStorage)
        {
            _userStorage = userStorage;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<User>>> GetAllUsersAsync()
        {
            return Ok(await _userStorage.GetAllUsers());
        }

    }
}
