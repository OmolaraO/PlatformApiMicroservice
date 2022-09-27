using Microsoft.EntityFrameworkCore;
using PlatformSevice.Models;

namespace PlatformSevice.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
        }
        public DbSet<Platform> Platforms { get; set; }
    }
}
