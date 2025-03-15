using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecruiterPortal.Model;

namespace RecruiterPortal.Repository.Cfg
{
    public class ApplicationCfg : BaseCgfDatabase<JobApplicationModel>
    {
        public override void ConfigureColumns(EntityTypeBuilder<JobApplicationModel> builder)
        {
            builder.Property(x => x.ApplicationType).HasColumnName("applicationtype");
            builder.Property(x => x.ApplicationUrl).HasColumnName("applicationurl");
            builder.Property(x => x.ContactUrl).HasColumnName("contacturl");
            builder.Property(x => x.JobDescriptionUrl).HasColumnName("jobdescriptionurl");
            builder.Property(x => x.ApplicationData).HasColumnName("applicationdata");
            builder.Property(x => x.CompanyName).HasColumnName("companyname");
            builder.Property(x => x.Id).HasColumnName("id");
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
            builder.ToTable("jobapplication");
        }
    }
}
