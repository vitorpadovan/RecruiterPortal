using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecruiterPortal.Model;

namespace RecruiterPortal.Repository.Cfg
{
    internal class AnaliseAiDataCfg : BaseCgfDatabase<AnaliseAiDataModel>
    {
        public override void ConfigureColumns(EntityTypeBuilder<AnaliseAiDataModel> builder)
        {
            builder.Property(x => x.RecruterUrl).HasColumnName("RECRUTERURL");
            builder.Property(x => x.RecruterName).HasColumnName("RECRUTERNAME");
            builder.Property(x => x.Competence).HasColumnName("COMPETENCE");
            builder.Property(x => x.Type).HasColumnName("TYPE");
            builder.Property(x => x.ApplicationDate).HasColumnName("APPLICATIONDATE");
            builder.Property(x => x.ApplicationUrl).HasColumnName("APPLICATIONURL");
            builder.Property(x => x.CompanyName).HasColumnName("COMPANYNAME");
            builder.Property(x => x.CompanyUrl).HasColumnName("COMPANYURL");
            builder.Property(x => x.Description).HasColumnName("DESCRIPTION");
            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.JobDescriptionUrl).HasColumnName("JOBDESCRIPTIONURL");
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
            builder.ToTable("ANALISEAIDATA");
        }
    }
}