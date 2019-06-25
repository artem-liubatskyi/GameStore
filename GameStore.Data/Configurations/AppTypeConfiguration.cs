using GameStore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.Data.Configurations
{
    public class AppTypeConfiguration : IEntityTypeConfiguration<AppType>
    {
        public void Configure(EntityTypeBuilder<AppType> builder)
        {
            builder.ToTable("AppType");

            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.Categories);
        }
    }
}
