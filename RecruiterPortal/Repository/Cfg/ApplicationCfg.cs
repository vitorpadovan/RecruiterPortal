using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecruiterPortal.Model;

namespace RecruiterPortal.Repository.Cfg
{
    public class ApplicationCfg : BaseCgfDatabase<JobApplicationModel>
    {
        public override void ConfigureColumns(EntityTypeBuilder<JobApplicationModel> builder)
        {
            
        }

        public override void ConfigureIndex(EntityTypeBuilder<JobApplicationModel> builder)
        {
            builder.HasIndex(x => new { x.ApplicationUrl }).IsUnique();
            builder.HasIndex(x => new { x.JobDescriptionUrl }).IsUnique();
            builder.HasIndex(x => new { x.ApplicationUrl, x.JobDescriptionUrl }).IsUnique();
        }

        public override void ConfigureKeys(EntityTypeBuilder<JobApplicationModel> builder)
        {
            
        }

        public override void ConfigureTable(EntityTypeBuilder<JobApplicationModel> builder)
        {
            
        }
    }
}
