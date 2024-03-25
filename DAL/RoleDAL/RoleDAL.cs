using DAL.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.RoleDAL
{
    public  class RoleDAL: IRoleDAL
    {
        private readonly DatabaseContext _databaseContext;

        public RoleDAL(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<List<Role>> GetRoles()
        { 
          return await  _databaseContext.Role.ToListAsync();
        }

        public async Task<Role> GetRoleById(int id)
        { 
            return await _databaseContext.Role.FindAsync(id);
        
        }

        public async Task AddNewRolde(Role role)
        { 

            _databaseContext.Role.Add(role);
          await  _databaseContext.SaveChangesAsync();
        }
    }
}
