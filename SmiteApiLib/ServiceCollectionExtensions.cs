using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static void AddSmiteApiServices(this IServiceCollection services, SmiteApiSettings apiSettings)
    {
        ApiSettings.Init(apiSettings);

        services.AddHttpClient<IConnectivityService>();
        services.AddScoped<IConnectivityService, ConnectivityService>();

        services.AddHttpClient<IGodsAndItemsService>();
        services.AddScoped<IGodsAndItemsService, GodsAndItemsService>();
    }
}