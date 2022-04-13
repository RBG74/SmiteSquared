using SmiteApiLib.Models.DTO;
using SmiteApiLib.Ressources.Constants;
using System.Text.Json;

public class ConnectivitySmiteApi : BaseSmiteApi, IConnectivitySmiteApi
{

    public ConnectivitySmiteApi(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
    {
    }

    public async Task<string> Ping()
    {
        if (!ApiSettings.WasInitialized) throw new ApiSettingsNotInitializedException();

        var url = $"{ApiStuff.BaseUrl}/{ApiMethodEnum.Ping.GetMethodNameAndFormat(ApiSettings.ResponseFormat)}";
        var jsonResponse = await ExecuteRequest(url);
        return jsonResponse;
    }

    public async Task<string> GetDataUsed()
    {
        var url = ApiUriHelper.GetBaseApiUrl(ApiMethodEnum.GetDataUsed);
        var jsonResponse = await ExecuteRequest(url);
        return jsonResponse;
    }

    public async Task<IEnumerable<GetHirezServerStatusDTO>> GetHirezServerStatus()
    {
        var url = ApiUriHelper.GetBaseApiUrl(ApiMethodEnum.GetHirezServerStatus);
        var jsonResponse = await ExecuteRequest(url);
        var response = JsonSerializer.Deserialize<IEnumerable<GetHirezServerStatusDTO>>(jsonResponse);
        return response;
    }

    public async Task<string> GetPatchInfo()
    {
        var url = ApiUriHelper.GetBaseApiUrl(ApiMethodEnum.GetPatchInfo);
        var jsonResponse = await ExecuteRequest(url);
        return jsonResponse;
    }
}