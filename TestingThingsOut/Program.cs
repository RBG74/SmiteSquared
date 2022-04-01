
using SmiteApiLib;

var smiteApiHelper = new SmiteApiHelper();

//var pingResult = await smiteApi.Ping();
//Console.WriteLine(pingResult);

var createSessionResult = await smiteApiHelper.GetServerStatus();
Console.Read();