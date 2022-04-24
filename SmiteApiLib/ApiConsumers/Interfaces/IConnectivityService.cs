using SmiteApiLib.Models.DTO;

namespace SmiteApiLib.ApiConsumers
{
    public interface IConnectivityService
    {
        Task<string> Ping();

        Task<IEnumerable<GetDataUsedDTO>> GetDataUsed();

        Task<IEnumerable<GetHirezServerStatusDTO>> GetHirezServerStatus();

        Task<GetPatchInfoDTO> GetPatchInfo();
    }
}