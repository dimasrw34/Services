using System.Data;
using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

//.5. IPlatformRepo concrate class
namespace PlatformService.Data
{
    public class PlatformRepo(AppDbContext context) : IPlatformRepo 
    {
        private readonly AppDbContext _context = context;
        public void CretePlatform(Platform platform)
        {
            if (platform == null)
            {
                throw new ArgumentNullException(nameof(platform));
            }

            _context.Platforms.Add(platform);
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _context.Platforms.ToList();
        }

        public Platform? GetPlatformById(int id)
        {
            return _context.Platforms.FirstOrDefault(p => p.Id == id);   
        }

        public bool SaveChange()
        {
         return (_context.SaveChanges() >= 0);
        }
    }
}