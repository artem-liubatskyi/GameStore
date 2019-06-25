using GameStore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.Data.Configurations
{
    public class UserAppConfiguration : IEntityTypeConfiguration<UserApp>
    {
        public void Configure(EntityTypeBuilder<UserApp> builder)
        {
            builder.ToTable("UserApp");

            builder.HasKey(x => new { x.AppId, x.UserId });

            builder.HasOne(x => x.User)
                 .WithMany(x => x.Apps)
                 .HasForeignKey(x => x.UserId);
        }
    }
}
