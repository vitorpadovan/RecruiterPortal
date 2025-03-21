﻿using RecruiterPortal.Controllers.Request.Application;
using RecruiterPortal.Model;

namespace RecruiterPortal.Repository.Interfaces
{
    public interface IApplicationRepo
    {
        Task SaveAiAnalyse(AnalyseAiRequest newAiAnalyse);
        Task<JobApplicationModel> SaveApplication(JobApplicationModel newApplicationRequest);
    }
}
