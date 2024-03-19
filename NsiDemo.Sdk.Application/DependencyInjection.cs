using Microsoft.Extensions.DependencyInjection;
using NsiDemo.Sdk.Application.Client;

namespace NsiDemo.Sdk.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddNsiDemoSdk(this IServiceCollection services)
    {
        services.AddScoped<INsiDemoSdkClient, NsiDemoSdkClient>();
        return services;
    }
}
