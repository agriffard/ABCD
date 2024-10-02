namespace ABCD.Core.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection ConfigureSettings(this IServiceCollection services, IConfiguration config)
    {
        services.Configure<AppSettings>(config.GetSection(nameof(AppSettings)));
        return services;
    }
}
