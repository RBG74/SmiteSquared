using SmiteApiLib.Models;

namespace SmiteApiLib.ApiConsumers
{
    public class FakeConnectivityService : IConnectivityService
    {
        public Task<IEnumerable<GetDataUsed>> GetDataUsed()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GetHirezServerStatus>> GetHirezServerStatus()
        {
            throw new NotImplementedException();
        }

        public Task<GetPatchInfo> GetPatchInfo()
        {
            throw new NotImplementedException();
        }

        public Task<string> Ping()
        {
            throw new NotImplementedException();
        }
    }
}