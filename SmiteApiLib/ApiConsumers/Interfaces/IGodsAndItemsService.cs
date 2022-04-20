﻿using SmiteApiLib.Models.DTO;
using SmiteApiLib.Ressources.Enums;

namespace SmiteApiLib.ApiConsumers
{
    public interface IGodsAndItemsService
    {
        Task<IEnumerable<GodDTO>> GetGods();
        Task<string> GetGodLeaderBoard(int godId, QueueEnum queue);
        Task<string> GetGodAbilities();
        Task<string> GetGodSkins(int godId);
        Task<string> GetGodRecommendedItems(int godId);
        Task<string> GetItems();
    }
}