using RecruiterPortal.Controllers.Request.Application;
using RecruiterPortal.Model;

namespace RecruiterPortal.Controllers.Response.Application
{
    public class NewApplicationResponse
    {
        public Guid Id { get; set; }
        public required string CompanyName { get; set; }
        public Uri? ContactUrl { get; set; }
        public required DateTime ApplicationData { get; set; }
        public required Uri JobDescriptionUrl { get; set; }
        public ApplicationTypeEnum ApplicationType { get; set; }
        public Uri? ApplicationUrl { get; set; }

        public static implicit operator NewApplicationResponse(JobApplicationModel v)
        {
            return new()
            {
                Id = v.Id,
                CompanyName = v.CompanyName,
                ContactUrl = v.ContactUrl,
                ApplicationData = v.ApplicationData,
                JobDescriptionUrl = v.JobDescriptionUrl,
                ApplicationType = v.ApplicationType,
                ApplicationUrl = v.ApplicationUrl
            };
        }
    }
}
