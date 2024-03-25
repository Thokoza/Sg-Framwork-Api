using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public partial class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {

        }
        public virtual DbSet<Person> Person { get; set; } = null;
        public virtual DbSet<Role> Role { get; set; } = null;
        public virtual DbSet<User> Users { get; set; } = null;
    }
}
