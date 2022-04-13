public class GodsAndItemsService : BaseSmiteApi, IGodsAndItemsService
{
    public GodsAndItemsService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
    {
    }

    public Task<string> GetGods()
    {
        throw new NotImplementedException();
    }
    public Task<string> GetGodLeaderBoard(int godId, QueueEnum queue)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetGodAbilities()
    {
        throw new NotImplementedException();
    }

    public Task<string> GetGodSkins(int godId)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetGodRecommendedItems(int godId)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetItems()
    {
        throw new NotImplementedException();
    }

}
