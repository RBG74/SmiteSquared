using System.Reflection;

internal static class LocalSessionHelper
{
    private static string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Ressources\Session.json");

    internal static string? GetExistingSessionId()
    {
        if(!File.Exists(path)) return null;
        var sessionId = File.ReadAllText(path);
        return sessionId;
    }

    internal static void StoreSessionId(string sessionId)
    {
        File.WriteAllText(path, sessionId);
    }
}
