using Microsoft.Extensions.Logging;
using SmiteApiLib.Models.DTO;
using SmiteApiLib.Ressources.Constants;
using SmiteApiLib.Ressources.Enums;
using SmiteApiLib.Ressources.Exceptions;
using SmiteApiLib.Ressources.Helpers;
using System.Text.Json;

namespace SmiteApiLib.ApiConsumers
{
    public class ConnectivityService : BaseSmiteApi, IConnectivityService
    {
        public ConnectivityService(IHttpClientFactory httpClientFactory, ILoggerFactory loggerFactory) : base(httpClientFactory)
        {
            _logger = loggerFactory.CreateLogger<ConnectivityService>();
        }

        public async Task<string> Ping()
        {
            _logger?.LogInformation($"Calling method {nameof(Ping)}");

            try
            {
                if (!ApiSettings.WasInitialized) throw new ApiSettingsNotInitializedException();

                var url = $"{ApiStuff.BaseUrl}/{ApiMethodEnum.Ping.GetMethodNameAndFormat(ApiSettings.ResponseFormat)}";
                var jsonResponse = await ExecuteRequest(url);
                return jsonResponse;
            }
            catch (Exception ex)
            {
                ManageException(ex);
                throw;
            }
        }

        public async Task<IEnumerable<GetDataUsedDTO>> GetDataUsed()
        {
            _logger?.LogInformation($"Calling method {nameof(GetDataUsed)}");

            try
            {
                var url = ApiUriHelper.GetBaseApiUrl(ApiMethodEnum.GetDataUsed);
                var jsonResponse = await ExecuteRequest(url);
                var response = JsonSerializer.Deserialize<IEnumerable<GetDataUsedDTO>>(jsonResponse)!;
                return response;
            }
            catch (Exception ex)
            {
                ManageException(ex);
                throw;
            }
        }

        public async Task<IEnumerable<GetHirezServerStatusDTO>> GetHirezServerStatus()
        {
            _logger?.LogInformation($"Calling method {nameof(GetHirezServerStatus)}");

            try
            {
                var url = ApiUriHelper.GetBaseApiUrl(ApiMethodEnum.GetHirezServerStatus);
                var jsonResponse = await ExecuteRequest(url);
                var response = JsonSerializer.Deserialize<IEnumerable<GetHirezServerStatusDTO>>(jsonResponse)!;
                return response;
            }
            catch (Exception ex)
            {
                ManageException(ex);
                throw;
            }
        }

        public async Task<GetPatchInfoDTO> GetPatchInfo()
        {
            _logger?.LogInformation($"Calling method {nameof(GetPatchInfo)}");

            try
            {
                var url = ApiUriHelper.GetBaseApiUrl(ApiMethodEnum.GetPatchInfo);
                var jsonResponse = await ExecuteRequest(url);
                var response = JsonSerializer.Deserialize<GetPatchInfoDTO>(jsonResponse)!;
                return response;
            }
            catch (Exception ex)
            {
                ManageException(ex);
                throw;
            }
        }
    }
}