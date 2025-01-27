using Microsoft.AspNetCore.Mvc.ApplicationModels;
using RecruiterPortal.Controllers.Request.Application;
using RecruiterPortal.Model;

namespace RecruiterPortal.Business.Interfaces
{
    public interface IApplicationBusiness
    {
        Task<JobApplicationModel> SaveApplication(JobApplicationModel newApplicationRequest);
    }
}
