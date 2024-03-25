using BL.DTO;
using DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.RoleBLL
{
    public  interface IRoleBLL
    {
        Task<IEnumerable<RoleDTO>> GetRoles();
        Task<RoleDTO> GetRoleById(int id);
        Task<string> AddNewRolde(RoleDTO role);
    }
}
