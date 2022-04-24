using System.Reflection;

namespace SmiteApiLib.Ressources.Helpers
{
    internal static class LocalSessionHelper
    {
        private static string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Ressources\Session.json");

        internal static async Task<string?> GetExistingSessionId()
        {
            if (!File.Exists(path)) return null;
            var sessionId = await File.ReadAllTextAsync(path);
            return sessionId;
        }

        internal static async Task WriteSessionId(string sessionId)
        {
            await File.WriteAllTextAsync(path, sessionId);
        }
    }
}