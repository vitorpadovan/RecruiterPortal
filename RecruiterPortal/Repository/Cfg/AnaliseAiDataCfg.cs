using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecruiterPortal.Model;

namespace RecruiterPortal.Repository.Cfg
{
    internal class AnaliseAiDataCfg : BaseCgfDatabase<AnaliseAiDataModel>
    {
        public override void ConfigureColumns(EntityTypeBuilder<AnaliseAiDataModel> builder)
        {
            builder.Property(x => x.RecruterUrl).HasColumnName("recruterurl");
            builder.Property(x => x.RecruterName).HasColumnName("recrutername");
            builder.Property(x => x.Competence).HasColumnName("competence");
            builder.Property(x => x.Type).HasColumnName("type");
            builder.Property(x => x.ApplicationDate).HasColumnName("applicationdate");
            builder.Property(x => x.ApplicationUrl).HasColumnName("applicationurl");
            builder.Property(x => x.CompanyName).HasColumnName("companyname");
            builder.Property(x => x.CompanyUrl).HasColumnName("companyurl");
            builder.Property(x => x.Description).HasColumnName("description");
            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.JobDescriptionUrl).HasColumnName("jobdescriptionurl");
        }

        public override void ConfigureIndex(EntityTypeBuilder<AnaliseAiDataModel> builder)
        {

        }

        public override void ConfigureKeys(EntityTypeBuilder<AnaliseAiDataModel> builder)
        {
            builder.HasKey(x => x.Id);
        }

        public override void ConfigureTable(EntityTypeBuilder<AnaliseAiDataModel> builder)
        {
            builder.ToTable("analiseaidata");
        }
    }
}