using Microsoft.EntityFrameworkCore;
using ApiUsersApplication.Models;

namespace ApiUsersApplication.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Define DbSets for your entities here
        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure entity properties and relationships here
            // modelBuilder.Entity<User>().ToTable("Users");
            // modelBuilder.Entity<Role>().ToTable("Roles");
        }
    }
}
