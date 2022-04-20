namespace SmiteApiLib.Ressources.Exceptions
{
    public class ApiSettingsNotInitializedException : Exception
    {
        public ApiSettingsNotInitializedException() : base($"The {nameof(ApiSettings)} static object needs to be initialized using its {nameof(ApiSettings.Init)} method.")
        {
        }
    }
}