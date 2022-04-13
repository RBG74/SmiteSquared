using Microsoft.Extensions.Logging;

public class GodsAndItemsService : BaseSmiteApi, IGodsAndItemsService
{
    public GodsAndItemsService(IHttpClientFactory httpClientFactory, ILoggerFactory loggerFactory) : base(httpClientFactory)
    {
        _logger = loggerFactory.CreateLogger<GodsAndItemsService>();
    }

    public Task<string> GetGods()
    {
        _logger?.LogInformation($"Calling method {nameof(GetGods)}");

        throw new NotImplementedException();
    }
    public Task<string> GetGodLeaderBoard(int godId, QueueEnum queue)
    {
        _logger?.LogInformation($"Calling method {nameof(GetGodLeaderBoard)}");

        throw new NotImplementedException();
    }

    public Task<string> GetGodAbilities()
    {
        _logger?.LogInformation($"Calling method {nameof(GetGodAbilities)}");

        throw new NotImplementedException();
    }

    public Task<string> GetGodSkins(int godId)
    {
        _logger?.LogInformation($"Calling method {nameof(GetGodSkins)}");

        throw new NotImplementedException();
    }

    public Task<string> GetGodRecommendedItems(int godId)
    {
        _logger?.LogInformation($"Calling method {nameof(GetGodRecommendedItems)}");

        throw new NotImplementedException();
    }

    public Task<string> GetItems()
    {
        _logger?.LogInformation($"Calling method {nameof(GetItems)}");

        throw new NotImplementedException();
    }

}
