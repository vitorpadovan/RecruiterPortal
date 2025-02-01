using RecruiterPortal.Model;

namespace RecruiterPortal.Controllers.Request.Application
{
    public class NewApplicationRequest
    {
        public required string CompanyName { get; set; }
        public Uri? ContactUrl { get; set; }
        public required Uri JobDescriptionUrl { get; set; }
        public required ApplicationType ApplicationType { get; set; }
        public Uri? ApplicationUrl { get; set; }
    }
}
