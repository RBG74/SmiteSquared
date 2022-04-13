using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddSmiteApiServices(new SmiteApiSettings(ApiKeys.DevId, ApiKeys.AuthKey));

var provider = services.BuildServiceProvider();

var connectivitySmiteService = provider.GetService<IConnectivityService>();

var test = await connectivitySmiteService.GetHirezServerStatus();

Console.Read();