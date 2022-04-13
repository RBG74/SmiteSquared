using SmiteApiLib.Models.DTO;

public interface IConnectivitySmiteApi
{
    Task<string> Ping();
    Task<string> GetDataUsed();
    Task<IEnumerable<GetHirezServerStatusDTO>> GetHirezServerStatus();
    Task<string> GetPatchInfo();
}