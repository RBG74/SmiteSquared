namespace SmiteApiLib.Ressources.Enums
{
    internal enum ApiMethodEnum
    {
        Ping,
        CreateSession,
        TestSession,
        GetDataUsed,
        GetHirezServerStatus,
        GetPatchInfo,
        GetGods,
    }

    internal static class ApiMethodEnumExtensions
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
                ApiMethodEnum.GetGods => "getgods",
                _ => throw new ArgumentOutOfRangeException(nameof(method)),
            };
        }

        public static string GetMethodNameAndFormat(this ApiMethodEnum method, ResponseFormatEnum responseFormat)
        {
            return method.GetMethodName() + responseFormat.ToFriendlyString();
        }
    }
}