using Microsoft.Extensions.Logging;
using SmiteApiLib.Models.DTO;
using System.Text.Json;
using System.Text.Json.Serialization;

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
    public async Task<string> GetGodLeaderBoard(int godId, QueueEnum queue)
    {
        _logger?.LogInformation($"Calling method {nameof(GetGodLeaderBoard)}");

        throw new NotImplementedException();
    }

    public async Task<string> GetGodAbilities()
    {
        _logger?.LogInformation($"Calling method {nameof(GetGodAbilities)}");

        throw new NotImplementedException();
    }

    public async Task<string> GetGodSkins(int godId)
    {
        _logger?.LogInformation($"Calling method {nameof(GetGodSkins)}");

        throw new NotImplementedException();
    }

    public async Task<string> GetGodRecommendedItems(int godId)
    {
        _logger?.LogInformation($"Calling method {nameof(GetGodRecommendedItems)}");

        throw new NotImplementedException();
    }

    public async Task<string> GetItems()
    {
        _logger?.LogInformation($"Calling method {nameof(GetItems)}");

        throw new NotImplementedException();
    }

}
