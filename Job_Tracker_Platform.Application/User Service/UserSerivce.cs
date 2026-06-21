using Job_Tracker_Platform.Application.DTO;
using Job_Tracker_Platform.Application.Interfaces_Repository;
using Job_Tracker_Platform.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Tracker_Platform.Application.User_Service
{
    public class UserSerivce : IUserService
    {
        private IUserRepository _userRepository;

        public UserSerivce(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task CreateUserAsync(UserDTO userDTO)
        {
            var creat = new User
                (Guid.NewGuid(),
                 userDTO.FirstName,
                 userDTO.LastName,
                 userDTO.DateOfBirth);
            await _userRepository.AddUserAsync(creat); 
        }

        public async Task<UserOutputDTO?> GetUserByIdAsync(Guid userid)
        {
            User find = await _userRepository.Get_User_By_Id(userid);
            if(find == null)
            {
                throw new Exception("کاربر یافت نشد.");
            }

            return new UserOutputDTO
            {
                FirstName = find.FirstName,
                LastName = find.LastName,
                DateOfBirth = find.DateOfBirth
            };
        }
    }
}
