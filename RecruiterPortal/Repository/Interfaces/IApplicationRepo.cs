using RecruiterPortal.Model;

namespace RecruiterPortal.Repository.Interfaces
{
    public interface IApplicationRepo
    {
        Task<JobApplicationModel> SaveApplication(JobApplicationModel newApplicationRequest);
    }
}
