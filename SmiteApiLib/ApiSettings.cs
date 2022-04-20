using SmiteApiLib.Ressources.Enums;

namespace SmiteApiLib
{
    public class SmiteApiSettings
    {
        public SmiteApiSettings(string devId, string authKey)
        {
            DevId = devId;
            AuthKey = authKey;
        }

        public string DevId;
        public string AuthKey;
        public ResponseFormatEnum ResponseFormat = ResponseFormatEnum.Json;
        public LanguageCodeEnum LanguageCode = LanguageCodeEnum.English;
    }

    internal static class ApiSettings
    {
        public static void Init(SmiteApiSettings smiteApiSettings)
        {
            DevId = smiteApiSettings.DevId ?? throw new ArgumentNullException(nameof(smiteApiSettings.DevId));
            AuthKey = smiteApiSettings.AuthKey ?? throw new ArgumentNullException(nameof(smiteApiSettings.AuthKey));
            LanguageCode = smiteApiSettings.LanguageCode;
            ResponseFormat = smiteApiSettings.ResponseFormat;

            WasInitialized = true;
        }

        internal static bool WasInitialized = false;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        internal static string DevId;
        internal static string AuthKey;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        internal static ResponseFormatEnum ResponseFormat;
        internal static LanguageCodeEnum LanguageCode;
    }
}