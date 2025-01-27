using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RecruiterPortal.Repository
{
    public abstract class BaseCgfDatabase<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class
    {
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            this.ConfigureTable(builder);
            this.ConfigureKeys(builder);
            this.ConfigureIndex(builder);
            this.ConfigureColumns(builder);
        }

        public abstract void ConfigureTable(EntityTypeBuilder<TEntity> builder);
        public abstract void ConfigureKeys(EntityTypeBuilder<TEntity> builder);
        public abstract void ConfigureIndex(EntityTypeBuilder<TEntity> builder);
        public abstract void ConfigureColumns(EntityTypeBuilder<TEntity> builder);
    }
}
