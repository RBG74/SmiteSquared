internal interface IGodsAndItemsApi
{
    Task<string> GetGods();
    Task<string> GetGodLeaderBoard(int godId, QueueEnum queue);
    Task<string> GetGodAbilities();
    Task<string> GetGodSkins(int godId);
    Task<string> GetGodRecommendedItems(int godId);
    Task<string> GetItems();
}