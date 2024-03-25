using BL.DTO;
using DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.UserBLL
{
    public interface IUserBLL 
    {
        Task<List<UserDTO>> GetUsers();
        Task<UserDTO> GetUserById(string UserName);
        Task<string> AddNewUser(UserDTO user);
    }
}
