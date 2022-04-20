using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;
using SmiteApiLib;
using SmiteApiLib.ApiConsumers;
using SmiteApiLib.Ressources.Enums;

var services = new ServiceCollection();

services.AddLogging(config => config.AddDebug());
services.Configure<LoggerFilterOptions>(options => options.AddFilter<DebugLoggerProvider>(null /* category*/, LogLevel.Information));

services.AddSmiteApiServices(new SmiteApiSettings(ApiKeys.DevId, ApiKeys.AuthKey));

var provider = services.BuildServiceProvider();

var connectivitySmiteService = provider.GetService<IConnectivityService>();
var godsAndItemsService = provider.GetService<IGodsAndItemsService>()!;

//var test = await connectivitySmiteService.GetHirezServerStatus();
//var godLeaderboard = await godsAndItemsService.GetGodLeaderboard(1779, QueueEnum.ConquestRanked);
//var godSkins = await godsAndItemsService.GetGodSkins(1779);
var godRecommendedItems = await godsAndItemsService.GetGodRecommendedItems(1779);
//var t = await godsAndItemsService.GetGodAltAbilities();

Console.Read();