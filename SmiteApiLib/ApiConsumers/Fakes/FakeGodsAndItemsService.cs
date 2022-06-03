using Microsoft.Extensions.Logging;
using SmiteApiLib.Models;
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

        public Task<IEnumerable<GodAltAbility>> GetGodAltAbilities()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GodLeaderboard>> GetGodLeaderboard(int godId = 1779, QueueEnum queue = QueueEnum.ConquestRanked)
        {
            try
            {
                var filePath = Path.Combine(basePath, $"GetGodLeaderboard\\GetGodLeaderboard_{godId}.json");
                _logger?.LogInformation($"Getting file: {filePath}");
                var json = File.ReadAllText(filePath);
                var result = JsonSerializer.Deserialize<IEnumerable<GodLeaderboard>>(json)!;
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                ManageException(ex);
                throw;
            }
        }

        public Task<IEnumerable<GodRecommendedItem>> GetGodRecommendedItems(int godId = 1779, LanguageCodeEnum? languageCode = null)
        {
            try
            {
                var filePath = Path.Combine(basePath, $"GetGodRecommendedItems\\GetGodRecommendedItems_{godId}.json");
                _logger?.LogInformation($"Getting file: {filePath}");
                var json = File.ReadAllText(filePath);
                var result = JsonSerializer.Deserialize<IEnumerable<GodRecommendedItem>>(json)!;
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                ManageException(ex);
                throw;
            }
        }

        public Task<IEnumerable<God>> GetGods(LanguageCodeEnum? languageCode = null)
        {
            try
            {
                var filePath = Path.Combine(basePath, $"GetGods.json");
                _logger?.LogInformation($"Getting file: {filePath}");
                var json = File.ReadAllText(filePath);
                var result = JsonSerializer.Deserialize<IEnumerable<God>>(json)!;
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                ManageException(ex);
                throw;
            }
        }

        public Task<IEnumerable<GodSkin>> GetGodSkins(int godId = 1779, LanguageCodeEnum? languageCode = null)
        {
            try
            {
                var filePath = Path.Combine(basePath, $"GetGodSkins\\GetGodSkins_{godId}.json");
                _logger?.LogInformation($"Getting file: {filePath}");
                var json = File.ReadAllText(filePath);
                var result = JsonSerializer.Deserialize<IEnumerable<GodSkin>>(json)!;
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                ManageException(ex);
                throw;
            }
        }

        public Task<IEnumerable<Item>> GetItems(LanguageCodeEnum? languageCode = null)
        {
            try
            {
                var filePath = Path.Combine(basePath, $"GetItems.json");
                _logger?.LogInformation($"Getting file: {filePath}");
                var json = File.ReadAllText(filePath);
                var result = JsonSerializer.Deserialize<IEnumerable<Item>>(json)!;
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