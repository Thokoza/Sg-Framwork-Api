using DAL.Data;
using DAL.RoleDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UserDAL
{
    public interface IUserDAL
    {
        Task<List<User>> GetUsers();
        Task<User> GetUserById(string UserName);
        Task AddNewUser(User user);
    }
}
