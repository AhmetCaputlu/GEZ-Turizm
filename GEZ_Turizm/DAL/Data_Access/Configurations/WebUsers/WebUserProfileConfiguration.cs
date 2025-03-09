using Data_Access.Entities.Enums;
using Data_Access.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access.Configurations.WebUsers
{
    public class WebUserProfileConfiguration : IEntityTypeConfiguration<WebUserProfile>
    {
        public void Configure(EntityTypeBuilder<WebUserProfile> builder)
        {
            builder.HasKey(x => x.WebUserId);
            builder.HasOne(x=>x.WebUser).WithOne(x=>x.WebUserProfile).HasForeignKey<WebUserProfile>(x=>x.WebUserId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(x => x.FirstName).HasMaxLength(30).IsRequired(true);
            builder.Property(x => x.LastName).HasMaxLength(30).IsRequired(true);
            builder.Property(x => x.BirthDate).IsRequired(true).HasDefaultValue(new DateTime(2000,01,01));
            builder.Property(x => x.Gender).IsRequired(true).HasDefaultValue(Gender.Unknown);
            builder.Property(x => x.TCN_PassportNumber).HasMaxLength(11).IsRequired(false);
            builder.Property(x => x.UserTier).IsRequired(true).HasDefaultValue(Tier.Basic);
            builder.Property(x => x.PhotoPath).IsRequired(false);
            builder.Property(x => x.UpdatedDate).IsRequired(true).HasDefaultValue(DateTime.Now);
        }
    }
}
