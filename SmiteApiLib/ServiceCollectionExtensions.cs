using Microsoft.Extensions.DependencyInjection;
using SmiteApiLib.ApiConsumers;

namespace SmiteApiLib
{
    public static class ServiceCollectionExtensions
    {
        public static void AddSmiteApiServices(this IServiceCollection services, SmiteApiSettings apiSettings)
        {
            if (string.IsNullOrWhiteSpace(apiSettings.DevId)) throw new ArgumentNullException(nameof(apiSettings.DevId));
            if (string.IsNullOrWhiteSpace(apiSettings.AuthKey)) throw new ArgumentNullException(nameof(apiSettings.AuthKey));
            ApiSettings.Init(apiSettings);

            services.AddHttpClient<IConnectivityService>();
            services.AddScoped<IConnectivityService, ConnectivityService>();

            services.AddHttpClient<IGodsAndItemsService>();
            services.AddScoped<IGodsAndItemsService, GodsAndItemsService>();
        }
    }
}