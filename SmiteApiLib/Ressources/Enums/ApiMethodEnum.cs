public enum ApiMethodEnum
{
    Ping,
    CreateSession,
    TestSession,
    GetDataUsed,
    GetHirezServerStatus,
    GetGods,
    GetPatchInfo,
}

public static class ApiMethodEnumExtensions
{
    public static string GetMethodName(this ApiMethodEnum method)
    {
        return method switch
        {
            ApiMethodEnum.Ping => "ping",
            ApiMethodEnum.CreateSession => "createsession",
            ApiMethodEnum.TestSession => "testsession",
            ApiMethodEnum.GetDataUsed => "getdataused",
            ApiMethodEnum.GetHirezServerStatus => "gethirezserverstatus",
            ApiMethodEnum.GetPatchInfo => "getpatchinfo",
            _ => throw new ArgumentOutOfRangeException(nameof(method)),
        };
    }

    public static string GetMethodNameAndFormat(this ApiMethodEnum method, ResponseFormatEnum responseFormat = ResponseFormatEnum.Json)
    {
        return method.GetMethodName() + responseFormat.ToFriendlyString();
    }
}