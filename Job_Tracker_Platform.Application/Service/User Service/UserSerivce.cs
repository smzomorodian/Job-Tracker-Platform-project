using Job_Tracker_Platform.Application.DTO.User;
using Job_Tracker_Platform.Application.Exceptions;
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

        public async Task DeleteUserAsync(Guid id)
        {
            var find = await _userRepository.Get_User_By_Id(id);
            if (find == null)
            {
                throw new NotFoundException("کاربر یافت نشد.");
            }
            await _userRepository.DeleteUser(find);
        }

        public async Task<List<UserOutputDTO>> GetAllUserDataAsync()
        {
            var finds = await _userRepository.GetAllUserData();
            return finds.Select(c => new UserOutputDTO
            {
                FirstName = c.FirstName,
                LastName = c.LastName,
                DateOfBirth = c.DateOfBirth

            }).ToList();
        }

        public async Task<UserOutputDTO?> GetUserByIdAsync(Guid userid)
        {
            User find = await _userRepository.Get_User_By_Id(userid);
            if (find == null)
            {
                throw new NotFoundException("کاربر یافت نشد.");
            }

            return new UserOutputDTO
            {
                FirstName = find.FirstName,
                LastName = find.LastName,
                DateOfBirth = find.DateOfBirth
            };
        }

        public async Task<UserOutputDTO> UpdateAsync(Guid id, UserDTO userDTO)
        {
            User user = await _userRepository.Get_User_By_Id(id);
            if (user == null)
            {
                throw new NotFoundException("کاربر یافت نشد.");
            }
            user.updateuser(userDTO.FirstName, userDTO.LastName, userDTO.DateOfBirth);

            await _userRepository.UpdateUser(user);

            var result = new UserOutputDTO
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                DateOfBirth = user.DateOfBirth
            };
            return result;
        }

        public async Task<UserOutputDTO> UpdateFirstNameUser(Guid id, ChangeFirstNameDto usernewfirstname)
        {
            User user = await _userRepository.Get_User_By_Id(id);
            if (user == null)
            {
                throw new NotFoundException("کاربر یافت نشد.");
            }

            user.UpdateFirstName(usernewfirstname.FirstName);
            await _userRepository.UpdateUser(user);

            var result = new UserOutputDTO
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                DateOfBirth = user.DateOfBirth
            };
            return result;
        }
    }
}
