using Job_Tracker_Platform.Application.DTO;
using Job_Tracker_Platform.Application.User_Service;
using Microsoft.AspNetCore.Mvc;

namespace Job_Tracker_Platform_project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserDTO dto)
        {
            await _userService.CreateUserAsync(dto);

            return Ok("User Created Successfully");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDataUser(Guid id)
        {
            var find = await _userService.GetUserByIdAsync(id);

            if (find == null)
                return NotFound("User not found");

            return Ok(find);
        }
    }
}
