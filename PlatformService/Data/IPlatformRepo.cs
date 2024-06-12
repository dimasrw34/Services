using PlatformService.Models;
//.4. ������� ��������� �����������
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