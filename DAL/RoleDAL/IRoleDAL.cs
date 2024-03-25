using DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.RoleDAL
{
    public  interface IRoleDAL
    {
        Task<List<Role>> GetRoles();
        Task<Role> GetRoleById(int id);
        Task AddNewRolde(Role role);
    }
}
