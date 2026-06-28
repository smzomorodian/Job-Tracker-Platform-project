using Job_Tracker_Platform.Application.DTO.User;
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
            return Ok(find);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDataUser()
        {
            var result = await _userService.GetAllUserDataAsync();
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserWitId(Guid id) // TODO
        {
            await _userService.DeleteUserAsync(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUserWitId(Guid id, UserDTO userDTO)
        {
            await _userService.UpdateAsync(id, userDTO);
            return Ok();
        }

        [HttpPut("{id}/firstname")]
        public async Task<IActionResult> UpdateUserNameWitId(Guid id, ChangeFirstNameDto userdto)
        {
            await _userService.UpdateFirstNameUser(id, userdto);
            return Ok();
        }

        //[HttpPatch]
    }
}
