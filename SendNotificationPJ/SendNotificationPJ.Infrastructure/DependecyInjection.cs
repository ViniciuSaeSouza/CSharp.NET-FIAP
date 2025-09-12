using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SendNotification.Infrastructure.Persistence;

namespace SendNotification.Infrastructure;

public static class DependecyInjection
{
    public static IServiceCollection AddDBContext(this IServiceCollection services, IConfiguration configuration)
    {
        return services.AddDbContext<SendNotificationPJContext>(options =>
        {
            var connectionString = configuration.GetConnectionString("MessageAPI");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString), my =>
            {
                my.EnableRetryOnFailure(); 
            });
        });
    }

    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
       return services.AddScoped<IMessageRepository, MessageRepository>();
    }
}