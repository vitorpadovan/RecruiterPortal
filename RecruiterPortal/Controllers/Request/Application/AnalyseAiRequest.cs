using RecruiterPortal.Model;

namespace RecruiterPortal.Controllers.Request.Application
{
    public class AnalyseAiRequest
    {
        public required string Description { get; set; }
        public required AnalyseAiType Type { get; set; }
        public Uri? ApplicationUrl { get; set; }
        public Uri? JobDescriptionUrl { get; set; }
        public string? RecruterName { get; set; }
        public Uri? RecruterUrl { get; set; }
        public string? Competence { get; set; }
        public string? CompanyName { get; set; }
        public Uri? CompanyUrl { get; set; }

        public static implicit operator AnaliseAiDataModel(AnalyseAiRequest v)
        {
            return new AnaliseAiDataModel()
            {
                Description = v.Description,
                Type = v.Type,
                ApplicationUrl = v.ApplicationUrl,
                JobDescriptionUrl = v.JobDescriptionUrl,
                RecruterName = v.RecruterName,
                RecruterUrl = v.RecruterUrl,
                CompanyName = v.CompanyName,
                CompanyUrl = v.CompanyUrl,
                Competence = v.Competence,
                ApplicationDate = DateTime.Now.ToUniversalTime()
            };
        }
    }
}
