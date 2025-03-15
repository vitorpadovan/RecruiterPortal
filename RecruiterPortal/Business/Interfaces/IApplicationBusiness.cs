using RecruiterPortal.Controllers.Request.Application;
using RecruiterPortal.Model;

namespace RecruiterPortal.Business.Interfaces
{
    public interface IApplicationBusiness
    {
        Task<List<AnaliseAiDataModel>> GetAnaliseAiData();
        Task SaveAnalyseAi(AnalyseAiRequest newAiAnalyse);
        Task<JobApplicationModel> SaveApplication(JobApplicationModel newApplicationRequest);
    }
}
