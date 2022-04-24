using Microsoft.Extensions.Logging;
using SmiteApiLib.Models.DTO;
using SmiteApiLib.Ressources.Enums;
using System.Reflection;
using System.Text.Json;

namespace SmiteApiLib.ApiConsumers
{
    public class FakeGodsAndItemsService : IGodsAndItemsService
    {
        private static string basePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Ressources\Jsons");
        protected ILogger? _logger;

        public FakeGodsAndItemsService(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<GodsAndItemsService>();
        }

        private void ManageException(Exception ex)
        {
            _logger?.LogError(ex.Message, ex);
            throw ex;
        }

        public Task<IEnumerable<GodAltAbilityDTO>> GetGodAltAbilities()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GodLeaderboardDTO>> GetGodLeaderboard(int godId = 1779, QueueEnum queue = QueueEnum.ConquestRanked)
        {
            try
            {
                var filePath = Path.Combine(basePath, $"GetGodLeaderboard\\GetGodLeaderboard_{godId}.json");
                _logger?.LogInformation($"Getting file: {filePath}");
                var json = File.ReadAllText(filePath);
                var result = JsonSerializer.Deserialize<IEnumerable<GodLeaderboardDTO>>(json)!;
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                ManageException(ex);
                throw;
            }
        }

        public Task<IEnumerable<GodRecommendedItemDTO>> GetGodRecommendedItems(int godId = 1779, LanguageCodeEnum? languageCode = null)
        {
            try
            {
                var filePath = Path.Combine(basePath, $"GetGodRecommendedItems\\GetGodRecommendedItems_{godId}.json");
                _logger?.LogInformation($"Getting file: {filePath}");
                var json = File.ReadAllText(filePath);
                var result = JsonSerializer.Deserialize<IEnumerable<GodRecommendedItemDTO>>(json)!;
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                ManageException(ex);
                throw;
            }
        }

        public Task<IEnumerable<GodDTO>> GetGods(LanguageCodeEnum? languageCode = null)
        {
            try
            {
                var filePath = Path.Combine(basePath, $"GetGods.json");
                _logger?.LogInformation($"Getting file: {filePath}");
                var json = File.ReadAllText(filePath);
                var result = JsonSerializer.Deserialize<IEnumerable<GodDTO>>(json)!;
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                ManageException(ex);
                throw;
            }
        }

        public Task<IEnumerable<GodSkinDTO>> GetGodSkins(int godId = 1779, LanguageCodeEnum? languageCode = null)
        {
            try
            {
                var filePath = Path.Combine(basePath, $"GetGodSkins\\GetGodSkins_{godId}.json");
                _logger?.LogInformation($"Getting file: {filePath}");
                var json = File.ReadAllText(filePath);
                var result = JsonSerializer.Deserialize<IEnumerable<GodSkinDTO>>(json)!;
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                ManageException(ex);
                throw;
            }
        }

        public Task<IEnumerable<ItemDTO>> GetItems(LanguageCodeEnum? languageCode = null)
        {
            try
            {
                var filePath = Path.Combine(basePath, $"GetItems.json");
                _logger?.LogInformation($"Getting file: {filePath}");
                var json = File.ReadAllText(filePath);
                var result = JsonSerializer.Deserialize<IEnumerable<ItemDTO>>(json)!;
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                ManageException(ex);
                throw;
            }
        }
    }
}