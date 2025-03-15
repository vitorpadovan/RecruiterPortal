using RecruiterPortal.Business.Interfaces;
using RecruiterPortal.Controllers.Request.Application;
using RecruiterPortal.Model;
using RecruiterPortal.Repository.Interfaces;

namespace RecruiterPortal.Business.Implementation
{
    public class ApplicationBusiness : IApplicationBusiness
    {
        private readonly IApplicationRepo _applicationRepo;
        private readonly IAiAnalyseRepo _aiAnalyseRepo;

        public ApplicationBusiness(IApplicationRepo applicationRepo, IAiAnalyseRepo aiAnalyseRepo)
        {
            _applicationRepo = applicationRepo;
            _aiAnalyseRepo = aiAnalyseRepo;
        }

        public Task<List<AnaliseAiDataModel>> GetAnaliseAiData()
        {
            return _aiAnalyseRepo.GetAnaliseAiData();
        }

        public async Task SaveAnalyseAi(AnalyseAiRequest newAiAnalyse)
        {
            await _aiAnalyseRepo.SaveAiAnalyse(newAiAnalyse);
        }

        public Task<JobApplicationModel> SaveApplication(JobApplicationModel newApplicationRequest)
        {
            newApplicationRequest.Id = Guid.NewGuid();
            newApplicationRequest.ApplicationData = newApplicationRequest.ApplicationData.ToUniversalTime();

            return _applicationRepo.SaveApplication(newApplicationRequest);
        }
    }
}
