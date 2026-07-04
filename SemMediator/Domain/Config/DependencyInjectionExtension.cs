using Microsoft.EntityFrameworkCore;
using SemMediator.Domain.Config.DatabaseContext;

namespace SemMediator.Domain.Config
{
    public static class DependencyInjectionExtension
    {
        public static void AddInfraestructure(this IServiceCollection services, IConfiguration configuration, string connectionStringName = "")
        {
            AddDbContext(services, configuration, connectionStringName);
        }

        private static void AddDbContext(IServiceCollection services, IConfiguration configuration, string connectionStringName = "")
        {
            var connectionString = configuration.GetConnectionString(connectionStringName);
            services.AddDbContext<CommandsDbContext>(config => config.UseSqlite(connectionString));
        }
    }
}
