using DAL.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UserDAL
{
    public class UserDAL:IUserDAL
    {
        private readonly DatabaseContext _databaseContext;

        public UserDAL(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public async Task<List<User>> GetUsers()
        { 
          return await _databaseContext.Users.ToListAsync();
        }

        public async Task<User> GetUserById(string UserName)
        {
            return await _databaseContext.Users.FindAsync(UserName);
        }

        public async Task AddNewUser(User user)
        { 
                 _databaseContext.Users.Add(user);
          await  _databaseContext.SaveChangesAsync();
        
        }
    }
}
