public enum ResponseFormatEnum
{
    Json,
    Xml
}

public static class ResponseFormatEnumExtensions
{
    public static string ToFriendlyString(this ResponseFormatEnum responseFormat)
    {
        switch (responseFormat)
        {
            case ResponseFormatEnum.Json:
                return "Json";

            case ResponseFormatEnum.Xml:
                return "Xml";

            default:
                throw new ArgumentOutOfRangeException(nameof(responseFormat));
        }
    }
}