namespace RecruiterPortal.Model
{
    public class AnaliseAiDataModel
    {
        public int Id { get; set; }
        public required string Description { get; set; }
        public required AnalyseAiType Type { get; set; }
        public Uri? ApplicationUrl { get; set; }
        public Uri? JobDescriptionUrl { get; set; }
        public string? RecruterName { get; set; }
        public Uri? RecruterUrl { get; set; }
        public string? CompanyName { get; set; }
        public Uri? CompanyUrl { get; set; }
        public string? Competence { get; set; }
        public DateTime ApplicationDate { get; set; }
    }
}
