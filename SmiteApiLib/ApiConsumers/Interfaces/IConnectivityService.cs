using SmiteApiLib.Models.DTO;

public interface IConnectivityService
{
    Task<string> Ping();
    Task<string> GetDataUsed();
    Task<IEnumerable<GetHirezServerStatusDTO>> GetHirezServerStatus();
    Task<GetPatchInfoDTO> GetPatchInfo();
}