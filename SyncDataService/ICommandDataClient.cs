using System.Threading.Tasks;
using PlatformSevice.Dtos;

namespace Platformsevice. SyncDataService. Http
{
    public interface ICommandDataClient
    {
        Task SendPlatformToCommand(PlatformReadDto plat);
    }
}