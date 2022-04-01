﻿using SmiteApiLib.Ressources.Constants;
using System.Text;

public static class ApiUriHelper
{
    /// <summary>
    /// Creates a base url of type {baseUrl}/{methodName[ResponseFormat]}/{developerId}/{signature}/{0}/{timestamp}
    /// </summary>
    /// <param name="method"></param>
    public static string GetBaseApiUrl(ApiMethodEnum method)
    {
        try
        {
            if (method == ApiMethodEnum.CreateSession) throw new ArgumentException($"Use method {nameof(GetCreateSessionUrl)} to get the url for {ApiMethodEnum.CreateSession.GetMethodName()}.");

            var timestamp = TimestampHelper.GetUtcTimestamp();

            var url = new StringBuilder()
                .Append(ApiStuff.BaseUrl + "/")
                .Append(method.GetMethodNameAndFormat() + "/")
                .Append(ApiKeys.DevId + "/")
                .Append(CreateSignature(method, timestamp) + "/")
                .Append("{0}/") //SessionId will be inserted here
                .Append(timestamp)
                .ToString();

            return url;
        }
        catch (Exception ex)
        {
            //TODO Handle logs
            throw;
        }
    }

    public static string GetCreateSessionUrl()
    {
        try
        {
            var timestamp = TimestampHelper.GetUtcTimestamp();
            var url = new StringBuilder()
                .Append(ApiStuff.BaseUrl + "/")
                .Append(ApiMethodEnum.CreateSession.GetMethodNameAndFormat() + "/")
                .Append(ApiKeys.DevId + "/")
                .Append(CreateSignature(ApiMethodEnum.CreateSession, timestamp) + "/")
                .Append(timestamp)
                .ToString();
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