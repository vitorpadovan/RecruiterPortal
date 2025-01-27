using Microsoft.EntityFrameworkCore;
using RecruiterPortal.Model;
using RecruiterPortal.Repository.Interfaces;

namespace RecruiterPortal.Repository.Implementation
{
    public class ApplicationRepo : BaseRepo<JobApplicationModel>, IApplicationRepo
    {
        public ApplicationRepo(AppDbContext context) : base(context,x=>x.JobApplication)
        {
        }

        public async Task<JobApplicationModel> SaveApplication(JobApplicationModel newApplicationRequest)
        {
            var result = await _dbSet.AddAsync(newApplicationRequest);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
    }
}
