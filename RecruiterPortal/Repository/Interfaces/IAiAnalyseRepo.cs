using RecruiterPortal.Controllers.Request.Application;
using RecruiterPortal.Model;

namespace RecruiterPortal.Repository.Interfaces
{
    public interface IAiAnalyseRepo
    {
        Task<List<AnaliseAiDataModel>> GetAnaliseAiData();
        Task SaveAiAnalyse(AnalyseAiRequest newAiAnalyse);
    }
}
