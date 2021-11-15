using IoTSensorAPI.Entities;
using IoTSensorAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace IoTSensorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(_userService.CreateUser(user));
        }
    }
}
