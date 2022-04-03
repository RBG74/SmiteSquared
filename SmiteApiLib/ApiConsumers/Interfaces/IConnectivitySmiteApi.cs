internal interface IConnectivitySmiteApi
{
    Task<string> Ping();
    Task<string> GetDataUsed();
    Task<string> GetHirezServerStatus();
    Task<string> GetPatchInfo();
}