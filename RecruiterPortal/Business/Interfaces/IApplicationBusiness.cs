using RecruiterPortal.Model;

namespace RecruiterPortal.Business.Interfaces
{
    public interface IApplicationBusiness
    {
        Task<JobApplicationModel> SaveApplication(JobApplicationModel newApplicationRequest);
    }
}
