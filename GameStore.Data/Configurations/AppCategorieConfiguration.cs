using GameStore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.Data.Configurations
{
    public class AppCategorieConfiguration : IEntityTypeConfiguration<AppCategorie>
    {
        public void Configure(EntityTypeBuilder<AppCategorie> builder)
        {
            builder.ToTable("AppCategorie");

            builder.HasKey(x => new { x.AppId, x.CategorieId });

            builder.HasOne(x => x.App)
                .WithMany(x => x.Categories)
                .HasForeignKey(x => x.AppId);

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Apps)
                .HasForeignKey(x => x.CategorieId);
        }
    }
}
