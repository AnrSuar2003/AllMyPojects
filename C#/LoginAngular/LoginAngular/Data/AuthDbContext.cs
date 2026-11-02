using LoginAngular.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginAngular.Data
{
    public class AuthDbContext : DbContext
    {

        public AuthDbContext(DbContextOptions<AuthDbContext> options)
       : base(options) { }

        public DbSet<User> Users => Set<User>();
        public DbSet<Role> Roles => Set<Role>();
    }
}
