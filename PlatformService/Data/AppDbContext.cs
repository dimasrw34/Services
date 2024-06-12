using Microsoft.EntityFrameworkCore;
using PlatformService.Models;
//.2. Создали дб контекст БД
namespace  PlatformService.Data
{
    public class  AppDbContext(DbContextOptions <AppDbContext> opt) : DbContext(opt)
    {
        public DbSet<Platform> Platforms { get; set; }

    }
    
}