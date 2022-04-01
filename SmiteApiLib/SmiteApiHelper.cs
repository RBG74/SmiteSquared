using SmiteApiLib.Models.ApiResponses;
using System.Text.Json;

namespace SmiteApiLib
{
    public class SmiteApiHelper
    {
        private readonly IConnectivitySmiteApi _connectivitySmiteApi;

        public SmiteApiHelper()
        {
            var httpClient = new HttpClient();
            _connectivitySmiteApi = new ConnectivitySmiteApi(httpClient);
        }

        public async Task<List<GetHirezServerStatusApiResponse>> GetServerStatus()
        {
            var json = await _connectivitySmiteApi.GetHirezServerStatus();
            var response = JsonSerializer.Deserialize<List<GetHirezServerStatusApiResponse>>(json);
            return response;
        }
    }
}
