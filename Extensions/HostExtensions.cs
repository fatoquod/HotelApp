using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HotelApp.Extensions
{
    public static class HostExtensions
    {
        
            public static IHost MigrateDatabase<TContext>(this IHost host) where TContext : DbContext
            {
                using var scope = host.Services.CreateScope();
                scope.ServiceProvider.GetRequiredService<TContext>().Database.Migrate();
                return host;
            }

        }
    
}