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
    }
}
