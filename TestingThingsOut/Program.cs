using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;


var services = new ServiceCollection();

services.AddLogging(config => config.AddDebug());
services.Configure<LoggerFilterOptions>(options => options.AddFilter<DebugLoggerProvider>(null /* category*/, LogLevel.Information));

services.AddSmiteApiServices(new SmiteApiSettings(ApiKeys.DevId, ApiKeys.AuthKey));

var provider = services.BuildServiceProvider();

var connectivitySmiteService = provider.GetService<IConnectivityService>();

var test = await connectivitySmiteService.GetHirezServerStatus();

Console.Read();