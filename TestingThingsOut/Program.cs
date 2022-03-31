
var smiteApi = new HttpClientConnectivitySmiteApi();

//var pingResult = await smiteApi.Ping();
//Console.WriteLine(pingResult);

var createSessionResult = await smiteApi.CreateSession();
Console.WriteLine(createSessionResult);