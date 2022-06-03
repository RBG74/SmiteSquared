using SmiteApiLib.Models;
using SmiteApiLib.Ressources.Enums;

namespace SmiteApiLib.ApiConsumers
{
    public interface IGodsAndItemsService
    {
        Task<IEnumerable<God>> GetGods(LanguageCodeEnum? languageCode = null);

        Task<IEnumerable<GodLeaderboard>> GetGodLeaderboard(int godId, QueueEnum queue);

        Task<IEnumerable<GodAltAbility>> GetGodAltAbilities();

        Task<IEnumerable<GodSkin>> GetGodSkins(int godId, LanguageCodeEnum? languageCode = null);

        Task<IEnumerable<GodRecommendedItem>> GetGodRecommendedItems(int godId, LanguageCodeEnum? languageCode = null);

        Task<IEnumerable<Item>> GetItems(LanguageCodeEnum? languageCode = null);
    }
}