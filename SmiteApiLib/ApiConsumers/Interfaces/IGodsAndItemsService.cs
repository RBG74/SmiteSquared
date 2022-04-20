using SmiteApiLib.Models.DTO;
using SmiteApiLib.Ressources.Enums;

namespace SmiteApiLib.ApiConsumers
{
    public interface IGodsAndItemsService
    {
        Task<IEnumerable<GodDTO>> GetGods();
        Task<IEnumerable<GodLeaderboardDTO>> GetGodLeaderboard(int godId, QueueEnum queue);
        Task<IEnumerable<GodAltAbilityDTO>> GetGodAltAbilities();
        Task<IEnumerable<GodSkinDTO>> GetGodSkins(int godId);
        Task<IEnumerable<GodRecommendedItemDTO>> GetGodRecommendedItems(int godId);
        Task<IEnumerable<ItemDTO>> GetItems();
    }
}