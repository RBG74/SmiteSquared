using Microsoft.Extensions.Logging;
using SmiteApiLib.Models.DTO;
using System.Text.Json;

public class ConnectivityService : BaseSmiteApi, IConnectivityService
{
    public ConnectivityService(IHttpClientFactory httpClientFactory, ILoggerFactory loggerFactory) : base(httpClientFactory)
    {
        _logger = loggerFactory.CreateLogger<ConnectivityService>();
    }

    public async Task<string> Ping()
    {
        _logger?.LogInformation($"Calling method {nameof(Ping)}");

        if (!ApiSettings.WasInitialized) throw new ApiSettingsNotInitializedException();

        var url = $"{ApiStuff.BaseUrl}/{ApiMethodEnum.Ping.GetMethodNameAndFormat(ApiSettings.ResponseFormat)}";
        var jsonResponse = await ExecuteRequest(url);
        return jsonResponse;
    }

    public async Task<string> GetDataUsed()
    {
        _logger?.LogInformation($"Calling method {nameof(GetDataUsed)}");

        var url = ApiUriHelper.GetBaseApiUrl(ApiMethodEnum.GetDataUsed);
        var jsonResponse = await ExecuteRequest(url);
        return jsonResponse;
    }

    public async Task<IEnumerable<GetHirezServerStatusDTO>> GetHirezServerStatus()
    {
        _logger?.LogInformation($"Calling method {nameof(GetHirezServerStatus)}");

        var url = ApiUriHelper.GetBaseApiUrl(ApiMethodEnum.GetHirezServerStatus);
        var jsonResponse = await ExecuteRequest(url);
        var response = JsonSerializer.Deserialize<IEnumerable<GetHirezServerStatusDTO>>(jsonResponse);
        return response;
    }

    public async Task<GetPatchInfoDTO> GetPatchInfo()
    {
        _logger?.LogInformation($"Calling method {nameof(GetPatchInfo)}");

        var url = ApiUriHelper.GetBaseApiUrl(ApiMethodEnum.GetPatchInfo);
        var jsonResponse = await ExecuteRequest(url);
        var response = JsonSerializer.Deserialize<GetPatchInfoDTO>(jsonResponse);
        return response;
    }
}