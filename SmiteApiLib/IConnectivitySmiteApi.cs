public interface IConnectivitySmiteApi
{
    Task<string> Ping();
    Task<string> CreateSession();
    Task<string> TestSession();
    Task<string> GetDataUsed();
    Task<string> GetHirezServerStatus();
}