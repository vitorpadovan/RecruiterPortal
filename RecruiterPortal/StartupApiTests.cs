using RecruiterPortal.Repository;

namespace RecruiterPortal
{
    public class StartupApiTests
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _environment;

        public StartupApiTests(IWebHostEnvironment environment, IConfiguration configuration)
        {
            _environment = environment;
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory, AppDbContext context)
        {
            try
            {
                context.Database.EnsureDeleted();
            }
            catch
            {

            }

            try
            {
                context.Database.EnsureCreated();
            }
            catch
            {

            }
            
            app.UseCors(builder => builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
