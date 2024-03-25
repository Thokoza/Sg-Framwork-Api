using BL.DTO;
using DAL.Data;
using DAL.UserDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BL.UserBLL
{
    public  class UserBLL :IUserBLL
    {
        public IUserDAL _userDAL;

        public UserBLL(IUserDAL userDAL) 
        {
         _userDAL = userDAL;
        }

        public async Task<IEnumerable<UserDTO>> GetUsers()
        { 
            var users = await _userDAL.GetUsers();

            return users.Select(x => new UserDTO
            {

                UserId = x.UserId,
                UserName = x.UserName,
                Email = x.Email
            });
        }
        public async Task<UserDTO> GetUserById(string UserName)
        { 
            var user = await _userDAL.GetUserById(UserName);
            return new UserDTO 
            { UserId = user.UserId,
              UserName = user.UserName,
              Email = user.Email};
        }
        public async Task<string> AddNewUser(UserDTO user)
        { 
         var message = string.Empty;
            await _userDAL.AddNewUser(new User
            {
                Email = user.Email,
                Password = user.Password,
                UserName = user.UserName,
            });

            message = $"{user.UserName} added successfully";
            return message;
        }

    }
}
