using Job_Tracker_Platform.Application.DTO.User;
using Job_Tracker_Platform.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Tracker_Platform.Application.User_Service
{
    public interface IUserService
    {
        Task CreateUserAsync(UserDTO userDTO);
        Task<UserOutputDTO?> GetUserByIdAsync(Guid userid);
        Task<List<UserOutputDTO>> GetAllUserDataAsync();
        Task DeleteUserAsync(Guid id);
        Task<UserOutputDTO> UpdateAsync(Guid id, UserDTO userDTO);
        Task<UserOutputDTO> UpdateFirstNameUser(Guid id, ChangeFirstNameDto usernewfirstname);
    }
}
