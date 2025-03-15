using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using RecruiterPortal.Repository;
using System.Runtime.CompilerServices;

namespace RecruiterPortal.Extension
{
    public static class DatabaseInitializationExtension
    {
        public static void InitDatabase(this IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var _logger = scope.ServiceProvider.GetRequiredService<ILogger<AppDbContext>>();
                var _configuration = scope.ServiceProvider.GetRequiredService<IConfiguration>();
                var _context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                try
                {
                    EnsureCreated(_context.Database);
                }
                catch(Exception ex)
                {
                    _logger.LogError(ex,"Erro ao criar o banco de dados");
                }
            }
        }

        private static void EnsureCreated(DatabaseFacade Database)
        {
            try
            {
                Database.EnsureCreated();
            }
            catch
            {
            }
            try
            {
                var migrations = Database.GetPendingMigrations();
            }
            catch
            {

            }
        }
    }
}
