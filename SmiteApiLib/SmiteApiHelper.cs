using SmiteApiLib.Models.ApiResponses;
using System.Text.Json;

namespace SmiteApiLib
{
    public class SmiteApiHelper
    {
        private readonly IConnectivitySmiteApi _connectivitySmiteApi;
        private readonly IGodsAndItemsApi _godsAndItemsApi;

        public SmiteApiHelper(HttpClient httpClient, ApiSettingsParameters apiSettingsParameters)
        {
            ApiSettings.Init(apiSettingsParameters);

            _connectivitySmiteApi = new ConnectivitySmiteApi(httpClient);
            _godsAndItemsApi = new GodsAndItemsApi(httpClient);
        }

        public async Task<List<GetHirezServerStatusApiResponse>> GetServerStatus()
        {
            var json = await _connectivitySmiteApi.GetHirezServerStatus();
            var response = JsonSerializer.Deserialize<List<GetHirezServerStatusApiResponse>>(json);
            return response;
        }
    }
}
