namespace ABCD.Core.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection ConfigureSettings(this IServiceCollection services, IConfiguration config)
    {
        services.AddOptions<AppSettings>().BindConfiguration(nameof(AppSettings)).ValidateDataAnnotations().ValidateOnStart();

        return services;
    }
}
