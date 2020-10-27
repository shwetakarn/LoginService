using LoginService.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginService.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions opt): base(opt)
        {
            
        }

        public DbSet<User> Users {get; set;}
    }
}