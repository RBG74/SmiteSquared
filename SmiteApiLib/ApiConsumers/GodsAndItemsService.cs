using Microsoft.Extensions.Logging;
using SmiteApiLib.Models.DTO;
using SmiteApiLib.Ressources.Enums;
using SmiteApiLib.Ressources.Helpers;
using System.Text.Json;

namespace SmiteApiLib.ApiConsumers
{
    public class GodsAndItemsService : BaseSmiteApi, IGodsAndItemsService
    {
        public GodsAndItemsService(IHttpClientFactory httpClientFactory, ILoggerFactory loggerFactory) : base(httpClientFactory)
        {
            _logger = loggerFactory.CreateLogger<GodsAndItemsService>();
        }

        public async Task<IEnumerable<GodDTO>> GetGods()
        {
            _logger?.LogInformation($"Calling method {nameof(GetGods)}");

            try
            {
                var baseUrl = ApiUriHelper.GetBaseApiUrl(ApiMethodEnum.GetGods);
                var url = $"{baseUrl}/{(int)ApiSettings.LanguageCode}";
                var jsonResponse = await ExecuteRequest(url);
                var response = JsonSerializer.Deserialize<IEnumerable<GodDTO>>(jsonResponse)!;
                return response;
            }
            catch (Exception ex)
            {
                ManageException(ex);
                throw;
            }
        }
        public async Task<IEnumerable<GodLeaderboardDTO>> GetGodLeaderboard(int godId, QueueEnum queue)
        {
            _logger?.LogInformation($"Calling method {nameof(GetGodLeaderboard)}");

            try
            {
                var baseUrl = ApiUriHelper.GetBaseApiUrl(ApiMethodEnum.GetGodLeaderboard);
                var url = $"{baseUrl}/{godId}/{(int)queue}";
                var jsonResponse = await ExecuteRequest(url);
                var response = JsonSerializer.Deserialize<IEnumerable<GodLeaderboardDTO>>(jsonResponse)!;
                return response;
            }
            catch (Exception ex)
            {
                ManageException(ex);
                throw;
            }
        }

        public async Task<IEnumerable<GodAltAbilityDTO>> GetGodAltAbilities()
        {
            _logger?.LogInformation($"Calling method {nameof(GetGodAltAbilities)}");

            try
            {
                var url = ApiUriHelper.GetBaseApiUrl(ApiMethodEnum.GetGodAltAbilities);
                var jsonResponse = await ExecuteRequest(url);
                var response = JsonSerializer.Deserialize<IEnumerable<GodAltAbilityDTO>>(jsonResponse)!;
                return response;
            }
            catch (Exception ex)
            {
                ManageException(ex);
                throw;
            }
        }

        public async Task<IEnumerable<GodSkinDTO>> GetGodSkins(int godId)
        {
            _logger?.LogInformation($"Calling method {nameof(GetGodSkins)}");

            try
            {
                var baseUrl = ApiUriHelper.GetBaseApiUrl(ApiMethodEnum.GetGodSkins);
                var url = $"{baseUrl}/{godId}/{(int)ApiSettings.LanguageCode}";
                var jsonResponse = await ExecuteRequest(url);
                var response = JsonSerializer.Deserialize<IEnumerable<GodSkinDTO>>(jsonResponse)!;
                return response;
            }
            catch (Exception ex)
            {
                ManageException(ex);
                throw;
            }
        }

        public async Task<IEnumerable<GodRecommendedItemDTO>> GetGodRecommendedItems(int godId)
        {
            _logger?.LogInformation($"Calling method {nameof(GetGodRecommendedItems)}");

            try
            {
                var baseUrl = ApiUriHelper.GetBaseApiUrl(ApiMethodEnum.GetGodRecommendedItems);
                var url = $"{baseUrl}/{godId}/{(int)ApiSettings.LanguageCode}";
                var jsonResponse = await ExecuteRequest(url);
                var response = JsonSerializer.Deserialize<IEnumerable<GodRecommendedItemDTO>>(jsonResponse)!;
                return response;
            }
            catch (Exception ex)
            {
                ManageException(ex);
                throw;
            }
        }

        public async Task<string> GetItems()
        {
            _logger?.LogInformation($"Calling method {nameof(GetItems)}");

            throw new NotImplementedException();
        }

    }
}