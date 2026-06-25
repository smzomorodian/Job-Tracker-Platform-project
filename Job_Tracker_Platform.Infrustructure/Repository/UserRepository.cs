using Job_Tracker_Platform.Application.Interfaces_Repository;
using Job_Tracker_Platform.Domain.Models;
using Job_Tracker_Platform.Infrustructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Tracker_Platform.Infrustructure.Repository
{
    public class UserRepository : IUserRepository
    {

        private readonly Appdbcontext _context;
        public UserRepository(Appdbcontext appContext)
        {
            _context = appContext;
        }

        public async Task AddUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUser(User user)
        {
            //var find = await Get_User_By_Id(id);
            //if(find == null)
            //{
            //    return;
            //}
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public Task<List<User>> GetAllUserData()
        {
            var finds = _context.Users.ToListAsync();
            return finds;
        }

        public async Task<User?> Get_User_By_Id(Guid userid)
        {
           return await _context.Users.Where(x => x.Id == userid).FirstOrDefaultAsync();
        }

        public async Task<User> UpdateUser(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
