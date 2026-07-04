using Job_Tracker_Platform.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Tracker_Platform.Application.Interfaces_Repository
{
    public interface IUserRepository
    {
        Task AddUserAsync(User user);
        Task<User?> GetUserById(Guid userid);
        Task<List<User>> GetAllUserData();
        Task DeleteUser(User user);
        Task<User> UpdateUser(User user);
    }
}
