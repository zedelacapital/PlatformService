using PlatformService.Models;
using System.Collections.Generic;
namespace PlatformService.Data
{
    public interface IPlatformRepo
    {
        bool SaveChangs();
        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById(int id);
        void CreatePlatform(Platform plat);
    }
}