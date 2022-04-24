using SmiteApiLib.Models.DTO;
using SmiteApiLib.Ressources.Enums;

namespace SmiteApiLib.ApiConsumers
{
    public interface IGodsAndItemsService
    {
        Task<IEnumerable<GodDTO>> GetGods(LanguageCodeEnum? languageCode = null);

        Task<IEnumerable<GodLeaderboardDTO>> GetGodLeaderboard(int godId, QueueEnum queue);

        Task<IEnumerable<GodAltAbilityDTO>> GetGodAltAbilities();

        Task<IEnumerable<GodSkinDTO>> GetGodSkins(int godId, LanguageCodeEnum? languageCode = null);

        Task<IEnumerable<GodRecommendedItemDTO>> GetGodRecommendedItems(int godId, LanguageCodeEnum? languageCode = null);

        Task<IEnumerable<ItemDTO>> GetItems(LanguageCodeEnum? languageCode = null);
    }
}