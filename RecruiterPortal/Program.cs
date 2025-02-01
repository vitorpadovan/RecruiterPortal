
using Microsoft.EntityFrameworkCore;
using RecruiterPortal.Business.Implementation;
using RecruiterPortal.Business.Interfaces;
using RecruiterPortal.Repository;
using RecruiterPortal.Repository.Implementation;
using RecruiterPortal.Repository.Interfaces;

namespace RecruiterPortal
{
    static class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            builder.Services.AddDbContext<AppDbContext>(opt =>
                opt.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSql"))
            );

            #region Injeção de Dependências
            builder.Services.AddScoped<IApplicationRepo, ApplicationRepo>();
            builder.Services.AddScoped<IApplicationBusiness, ApplicationBusiness>();
            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
