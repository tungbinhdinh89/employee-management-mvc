using EmployeeManagement.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Web
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var configrationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.Development.json", optional: true);

            var configuration = configrationBuilder.Build();
            var connectionString = configuration.GetConnectionString("DbContextConnection");

            Console.WriteLine($"Connection string: {connectionString}");

            //var assembly = Assembly.GetExecutingAssembly();

            var dbContextOptionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            dbContextOptionBuilder.UseSqlServer(connectionString, option =>
            {
                //option.MigrationsAssembly(assembly.FullName);
            });

            return new ApplicationDbContext(dbContextOptionBuilder.Options);
        }
    }
}
