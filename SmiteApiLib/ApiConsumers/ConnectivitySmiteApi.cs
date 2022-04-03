using SmiteApiLib.ApiConsumers;
using SmiteApiLib.Ressources.Constants;

internal class ConnectivitySmiteApi : BaseSmiteApi, IConnectivitySmiteApi
{

    public ConnectivitySmiteApi(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task<string> Ping()
    {
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

    public async Task<string> GetHirezServerStatus()
    {
        var url = ApiUriHelper.GetBaseApiUrl(ApiMethodEnum.GetHirezServerStatus);
        var jsonResponse = await ExecuteRequest(url);
        return jsonResponse;
    }

    public async Task<string> GetPatchInfo()
    {
        var url = ApiUriHelper.GetBaseApiUrl(ApiMethodEnum.GetPatchInfo);
        var jsonResponse = await ExecuteRequest(url);
        return jsonResponse;
    }
}