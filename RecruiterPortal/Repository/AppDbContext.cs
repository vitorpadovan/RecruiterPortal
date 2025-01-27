using Microsoft.EntityFrameworkCore;
using RecruiterPortal.Model;

namespace RecruiterPortal.Repository
{
    public class AppDbContext : DbContext
    {
        public DbSet<JobApplicationModel> JobApplication { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected AppDbContext()
        {
        }
    }
}
