using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecruiterPortal.Model;

namespace RecruiterPortal.Repository.Cfg
{
    public class ApplicationCfg : BaseCgfDatabase<JobApplicationModel>
    {
        public override void ConfigureColumns(EntityTypeBuilder<JobApplicationModel> builder)
        {
            builder.Property(x => x.ApplicationType).HasColumnName("APPLICATIONTYPE");
            builder.Property(x => x.ApplicationUrl).HasColumnName("APPLICATIONURL");
            builder.Property(x => x.ContactUrl).HasColumnName("CONTACTURL");
            builder.Property(x => x.JobDescriptionUrl).HasColumnName("JOBDESCRIPTIONURL");
            builder.Property(x => x.ApplicationData).HasColumnName("APPLICATIONDATA");
            builder.Property(x => x.CompanyName).HasColumnName("COMPANYNAME");
            builder.Property(x => x.Id).HasColumnName("ID");
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
            builder.ToTable("JOBAPPLICATION");
        }
    }
}
