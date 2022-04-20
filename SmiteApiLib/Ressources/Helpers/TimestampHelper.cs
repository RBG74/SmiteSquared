namespace SmiteApiLib.Ressources.Helpers
{
    internal static class TimestampHelper
    {
        public static string GetUtcTimestamp()
        {
            return DateTime.UtcNow.ToString("yyyyMMddHHmmss");
        }
    }
}