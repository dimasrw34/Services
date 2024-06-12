using PlatformService.Models;
//.4. Create repo interface
namespace PlatformService.Data
{
    public interface IPlatformRepo
    {
        bool SaveChange();
        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById(int id);
        void CretePlatform(Platform platform);
    }
}