using RecruiterPortal.Controllers.Request.Application;

namespace RecruiterPortal.Model
{
    public class JobApplicationModel
    {
        public Guid Id { get; set; }
        public required string CompanyName { get; set; }
        public Uri? ContactUrl { get; set; }
        public required DateTime ApplicationData { get; set; }
        public required Uri JobDescriptionUrl { get; set; }
        public ApplicationType ApplicationType { get; set; }
        public Uri? ApplicationUrl { get; set; }


        public static implicit operator JobApplicationModel(NewApplicationRequest v)
        {
            return new()
            {
                ApplicationData = DateTime.Now.ToUniversalTime(),
                CompanyName = v.CompanyName,
                JobDescriptionUrl = v.JobDescriptionUrl,
                ContactUrl = v.ContactUrl,
                ApplicationType = v.ApplicationType,
                ApplicationUrl = v.ApplicationUrl
            };
        }
    }
}
