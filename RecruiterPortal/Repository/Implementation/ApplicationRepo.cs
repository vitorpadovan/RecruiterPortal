using Microsoft.EntityFrameworkCore;
using RecruiterPortal.Model;
using RecruiterPortal.Repository.Interfaces;

namespace RecruiterPortal.Repository.Implementation
{
    public class ApplicationRepo : BaseRepo<JobApplicationModel>, IApplicationRepo
    {
        private readonly ILogger<ApplicationRepo> _logger;
        public ApplicationRepo(AppDbContext context, ILogger<ApplicationRepo> logger) : base(context, x => x.JobApplication)
        {
            _logger = logger;
        }

        public async Task<JobApplicationModel> SaveApplication(JobApplicationModel newApplicationRequest)
        {
            try
            {
                var result = await _dbSet.AddAsync(newApplicationRequest);
                await _context.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao tentar salvar o job {newApplicationRequest.CompanyName} com a URL {newApplicationRequest.JobDescriptionUrl}", ex);
            }

        }
    }
}
