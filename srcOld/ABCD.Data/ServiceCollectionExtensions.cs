namespace ABCD.Data;

/// <summary>
/// Provides extensions methods for <see cref="IServiceCollection"/>.
/// </summary>
public static class ServiceCollectionExtensions
{
    public static void AddDataRepositories(this IServiceCollection services)
    {
        services.AddScoped<ISampleRepository, SampleRepository>();
    }
}
