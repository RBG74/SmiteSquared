using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static void AddSmiteApiServices(this IServiceCollection services, SmiteApiSettings apiSettings)
    {
        ApiSettings.Init(apiSettings);

        services.AddHttpClient<IConnectivitySmiteApi>();
        services.AddScoped<IConnectivitySmiteApi, ConnectivitySmiteApi>();

        services.AddHttpClient<IGodsAndItemsApi>();
        services.AddScoped<IGodsAndItemsApi, GodsAndItemsApi>();
    }
}