using System.Reflection;

internal static class LocalSessionHelper
{
    private static string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Ressources\Session.json");

    internal async static Task<string?> GetExistingSessionId()
    {
        if (!File.Exists(path)) return null;
        var sessionId = await File.ReadAllTextAsync(path);
        return sessionId;
    }

    internal async static Task WriteSessionId(string sessionId)
    {
        await File.WriteAllTextAsync(path, sessionId);
    }
}
