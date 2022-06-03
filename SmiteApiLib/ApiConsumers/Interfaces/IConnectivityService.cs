using SmiteApiLib.Models;

namespace SmiteApiLib.ApiConsumers
{
    public interface IConnectivityService
    {
        Task<string> Ping();

        Task<IEnumerable<GetDataUsed>> GetDataUsed();

        Task<IEnumerable<GetHirezServerStatus>> GetHirezServerStatus();

        Task<GetPatchInfo> GetPatchInfo();
    }
}