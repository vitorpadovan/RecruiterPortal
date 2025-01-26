namespace RecruiterPortal.Model
{
    public class ApplicationModel
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public Uri ContactUrl { get; set; }
        public DateTime ApplicationData { get; set; }
        public Uri JobDescriptionUrl { get; set; }
        public ApplicationTypeEnum ApplicationType { get; set; }
        public Uri ApplicationUrl { get; set; }
    }
}
