 using BL.DTO;
using DAL.Data;
using DAL.RoleDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.RoleBLL
{
    public class RoleBLL : IRoleBLL
    {
        private readonly IRoleDAL _roleDAL;
        public RoleBLL(IRoleDAL roleDAL)
        {
            _roleDAL = roleDAL;
        }

        public async Task<IEnumerable<RoleDTO>> GetRoles()
        { 
          var roles = await _roleDAL.GetRoles();

            return roles.Select(x => new RoleDTO
            {
                RoleId = x.RoleId, RoleName = x.RoleName,
            });   
        }
        public async Task<RoleDTO> GetRoleById(int id)
        { 
          var role = await _roleDAL.GetRoleById(id);
            if (role == null) return null;

            return new RoleDTO
            {
                RoleId = role.RoleId,
                RoleName = role.RoleName
            };

        
        }
        public async Task<string> AddNewRolde(RoleDTO role)
        { 
            var message = string.Empty;
            await _roleDAL.AddNewRolde(new Role
            { 
             RoleName = role.RoleName,
            });
            message = $"{role.RoleName} added successfully";
            return message ;
        }
    }
}
