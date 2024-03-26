using EmployeeApi.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApi.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext>options):base(options) 
        {
                
        }
        public DbSet<UserModel> UserModels { get; set; }
        public DbSet<EmployeeModel> EmployeeModels { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeModel>().ToTable("tbl_employee");
            modelBuilder.Entity<UserModel>().ToTable("tbl_user");
        }

    }
}
