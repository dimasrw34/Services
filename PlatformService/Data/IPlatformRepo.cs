using PlatformService.Models;
//.4. Создали интерфейс репозитория
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