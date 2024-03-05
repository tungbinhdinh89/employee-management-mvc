using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagement.Core
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services, string connectionString)
        {
            return services
                .AddDbContext<ApplicationDbContext>(options =>
                {
                    options.UseSqlServer(connectionString)
                    .EnableSensitiveDataLogging(true)
                    .EnableDetailedErrors(true);
                })
                ;

        }
    }
}
