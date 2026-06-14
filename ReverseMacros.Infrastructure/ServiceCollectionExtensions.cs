using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using ReverseMacros.Infrastructure.Configurations;

namespace ReverseMacros.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<DatabaseSettings>(configuration.GetSection("ConnectionStrings"));

        var sp = services.BuildServiceProvider();
        var dbSettings = sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;

        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(
                dbSettings.DefaultConnection,
                x => x.MigrationsAssembly("ReverseMacros.Infrastructure")
            )
        );

        return services;
    }
}