using Microsoft.AspNetCore.Mvc.ApplicationModels;
using RecruiterPortal.Business.Interfaces;
using RecruiterPortal.Controllers.Request.Application;
using RecruiterPortal.Model;
using RecruiterPortal.Repository.Interfaces;

namespace RecruiterPortal.Business.Implementation
{
    public class ApplicationBusiness : IApplicationBusiness
    {
        private readonly IApplicationRepo _applicationRepo;

        public ApplicationBusiness(IApplicationRepo applicationRepo)
        {
            _applicationRepo = applicationRepo;
        }

        public Task<JobApplicationModel> SaveApplication(JobApplicationModel newApplicationRequest)
        {
            newApplicationRequest.Id = Guid.NewGuid();
            newApplicationRequest.ApplicationData = newApplicationRequest.ApplicationData.ToUniversalTime();

            return _applicationRepo.SaveApplication(newApplicationRequest);
        }
    }
}
