using SmiteApiLib.Models.DTO;

namespace SmiteApiLib.ApiConsumers
{
    public class FakeConnectivityService : IConnectivityService
    {
        public Task<IEnumerable<GetDataUsedDTO>> GetDataUsed()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GetHirezServerStatusDTO>> GetHirezServerStatus()
        {
            throw new NotImplementedException();
        }

        public Task<GetPatchInfoDTO> GetPatchInfo()
        {
            throw new NotImplementedException();
        }

        public Task<string> Ping()
        {
            throw new NotImplementedException();
        }
    }
}