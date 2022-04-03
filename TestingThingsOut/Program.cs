using SmiteApiLib;

#region Api initialization 
var httpClient = new HttpClient();
var apiSettings = new ApiSettingsParameters(ApiKeys.DevId, ApiKeys.AuthKey);
var smiteApiHelper = new SmiteApiHelper(httpClient, apiSettings);
#endregion

var createSessionResult = await smiteApiHelper.GetServerStatus();
Console.Read();