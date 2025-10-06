using Microsoft.EntityFrameworkCore;
using mvcEntityFrameworkCRUDProject.Models;

namespace mvcEntityFrameworkCRUDProject.Context
{
    public class DatabaseContext:DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Emp> Emps { get; set; }
    }
}
