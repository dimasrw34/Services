using Microsoft.EntityFrameworkCore;
using PlatformService.Models;
//.2. Create dbcontext
namespace  PlatformService.Data
{
    public class  AppDbContext(DbContextOptions <AppDbContext> opt) : DbContext(opt)
    {
        public DbSet<Platform> Platforms { get; set; }

    }
    
}