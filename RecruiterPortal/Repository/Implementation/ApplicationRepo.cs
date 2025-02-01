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
            _logger.LogInformation("Salvando a aplicação á uma vaga");
            try
            {
                var result = await _dbSet.AddAsync(newApplicationRequest);
                await _context.SaveChangesAsync();
                _logger.LogInformation("Aplicação salva");
                return result.Entity;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Erro ao tentar salvar o job {newApplicationRequest.CompanyName} com a URL {newApplicationRequest.JobDescriptionUrl}", ex);
            }
        }
    }
}
