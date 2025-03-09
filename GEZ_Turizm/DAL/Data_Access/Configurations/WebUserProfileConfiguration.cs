using Data_Access.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access.Configurations
{
    public class WebUserProfileConfiguration : IEntityTypeConfiguration<WebUserProfile>
    {
        public void Configure(EntityTypeBuilder<WebUserProfile> builder)
        {
            builder.Property(x=>x.FirstName).HasMaxLength(30).IsRequired(true);
            builder.Property(x => x.LastName).HasMaxLength(30).IsRequired(true);
            builder.Property(x=>x.BirthDate).IsRequired(false);
            builder.Property(x => x.Gender).IsRequired(false);
            builder.Property(x => x.TCN_PassportNumber).HasMaxLength(11).IsRequired(false);
            builder.Property(x => x.UserTier).IsRequired(true);
            builder.Property(x => x.PhotoPath).IsRequired(false);
            builder.Property(x => x.UpdatedDate).IsRequired(false);
        }
    }
}
