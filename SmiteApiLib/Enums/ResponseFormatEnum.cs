public enum ResponseFormatEnum
{
    None,
    Json,
    Xml
}

public static class ResponseFormatEnumExtensions
{
    public static string ToFriendlyString(this ResponseFormatEnum responseFormat)
    {
        switch (responseFormat)
        {
            case ResponseFormatEnum.None:
                return string.Empty;

            case ResponseFormatEnum.Json:
                return "Json";

            case ResponseFormatEnum.Xml:
                return "Xml";

            default:
                throw new ArgumentOutOfRangeException(nameof(responseFormat));
        }
    }
}