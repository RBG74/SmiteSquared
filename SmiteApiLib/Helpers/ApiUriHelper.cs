using System.Text;

public static class ApiUriHelper
{
    public static string CreateApiUri(ApiMethodEnum method, ResponseFormatEnum responseFormat = ResponseFormatEnum.Json)
    {
        try
        {
            var timestamp = TimestampHelper.GetUtcTimestamp();

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
                        .Append(timestamp);
                    break;
                case ApiMethodEnum.TestSession:
                case ApiMethodEnum.GetDataUsed:
                case ApiMethodEnum.GetHirezServerStatus:
                    sb.Append(method.GetMethodNameAndFormat(responseFormat) + "/")
                        .Append(ApiKeys.DevId + "/")
                        .Append(CreateSignature(method, timestamp) + "/")
                        .Append(SessionHelper.GetSessionId() + "/")
                        .Append(timestamp);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(method));
            }
            var url = sb.ToString();
            return url;
        }
        catch (Exception ex)
        {
            //TODO Handle logs
            throw;
        }
    }

    private static string CreateSignature(ApiMethodEnum method, string timestamp)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(timestamp)) throw new ArgumentNullException(nameof(timestamp));

            var toHash = ApiKeys.DevId + method.GetMethodName() + ApiKeys.AuthKey + timestamp;

            var signature = MD5Helper.CreateMD5Hash(toHash);

            return signature;
        }
        catch (Exception ex)
        {
            //TODO Handle logs
            throw;
        }
    }
}