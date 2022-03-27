using System.Text;

public static class ApiUriHelper
{
    public static string CreateApiUri(ApiMethodEnum method, ResponseFormatEnum responseFormat = ResponseFormatEnum.Json, string? timestamp = null)
    {
        var sb = new StringBuilder();
        sb.Append(Constants.BaseUrl + "/");

        switch (method)
        {
            case ApiMethodEnum.Ping:
                return $"{Constants.BaseUrl}/{ApiMethodEnum.Ping.GetMethodNameAndFormat()}";
            case ApiMethodEnum.CreateSession:
                sb.Append(method.GetMethodNameAndFormat(responseFormat) + "/")
                    .Append(ApiKeys.DevId + "/")
                    .Append(CreateSignature(method, timestamp) + "/")
                    .Append(timestamp ?? TimestampHelper.GetUtcTimestamp());
                    break;
            case ApiMethodEnum.TestSession:
            case ApiMethodEnum.GetDataUsed:
            case ApiMethodEnum.GetHirezServerStatus:
                sb.Append(method.GetMethodNameAndFormat(responseFormat) + "/")
                    .Append(ApiKeys.DevId + "/")
                    .Append(CreateSignature(method, timestamp) + "/")
                    .Append(SessionHelper.GetSessionId() + "/")
                    .Append(timestamp ?? TimestampHelper.GetUtcTimestamp());
                    break;
            default:
                throw new ArgumentOutOfRangeException(nameof(method));
        }
        return sb.ToString();
    }

    private static string CreateSignature(ApiMethodEnum method, string? timestamp = null)
    {
        var toHash = ApiKeys.DevId + method.GetMethodName() + ApiKeys.AuthKey + (timestamp ?? TimestampHelper.GetUtcTimestamp());

        var signature = MD5Helper.CreateMD5Hash(toHash);

        return signature;
    }
}