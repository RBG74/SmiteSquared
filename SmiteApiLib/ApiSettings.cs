public class ApiSettingsParameters
{
    public ApiSettingsParameters(
        string devId,
        string authKey,
        LanguageCodeEnum languageCode = LanguageCodeEnum.English,
        ResponseFormatEnum responseFormat = ResponseFormatEnum.Json)
    {
        DevId = devId;
        AuthKey = authKey;
        LanguageCode = languageCode;
        ResponseFormat = responseFormat;
    }

    public string DevId { get; init; }
    public string AuthKey { get; init; }
    public ResponseFormatEnum ResponseFormat { get; init; }
    public LanguageCodeEnum LanguageCode { get; init; }
}

internal static class ApiSettings
{
    public static void Init(ApiSettingsParameters apiSettingsParameters)
    {
        DevId = apiSettingsParameters.DevId;
        AuthKey = apiSettingsParameters.AuthKey;
        ResponseFormat = apiSettingsParameters.ResponseFormat;
        LanguageCode = apiSettingsParameters.LanguageCode;
    }

    public static string DevId;
    public static string AuthKey;
    public static ResponseFormatEnum ResponseFormat;
    public static LanguageCodeEnum LanguageCode;
}