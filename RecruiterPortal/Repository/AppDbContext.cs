using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RecruiterPortal.Model;
using RecruiterPortal.Repository.Cfg;

namespace RecruiterPortal.Repository
{
    public class AppDbContext : DbContext
    {
        public DbSet<JobApplicationModel> JobApplication { get; set; }
        public DbSet<AnaliseAiDataModel> AnaliseAiData { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected AppDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AnaliseAiDataCfg());
            modelBuilder.ApplyConfiguration(new ApplicationCfg());
        }
    }
}
