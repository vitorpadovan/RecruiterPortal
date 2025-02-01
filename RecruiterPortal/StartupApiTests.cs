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

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseCors(builder => builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
            //app.UseSession();
            app.UseRouting();
            //app.UseAuthentication();
            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.Use(async (context, next) =>
            {
                var endpointDataSource = context.RequestServices.GetRequiredService<EndpointDataSource>();
                var endpoints = endpointDataSource.Endpoints;
                foreach (var endpoint in endpoints)
                {
                    var routeEndpoint = endpoint as RouteEndpoint;
                    if (routeEndpoint != null)
                    {
                        Console.WriteLine($"Endpoint: {routeEndpoint.RoutePattern.RawText}");
                    }
                }
                await next.Invoke();
            });
        }


    }
}
