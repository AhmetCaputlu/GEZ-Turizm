using Data_Access.Entities.Enums;
using Data_Access.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access.Configurations
{
    internal class WebUserConfiguration : IEntityTypeConfiguration<WebUser>
    {
        public void Configure(EntityTypeBuilder<WebUser> builder)
        {
            //IEntity
            builder.Ignore(x => x.CustomID);
            builder.Property(x => x.UniqueIdentify).HasMaxLength(36).IsRequired(true).HasDefaultValue(Guid.NewGuid().ToString());
            builder.Property(x => x.CreatedTime).IsRequired(true).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedID).IsRequired(true).HasMaxLength(36).HasDefaultValue(Guid.NewGuid().ToString());
            //todo:Kayıt oluşturan kullanıcının Guid bilgisi atanacak.
            builder.Property(x => x.CreatedIPAddress).HasMaxLength(20).IsRequired(true).HasDefaultValue("");
            //todo:BLL katmanında kullanıcının IP bilgisi alınacak.(HttpContext)
            builder.Property(x => x.UpdatedTime).IsRequired(false);
            builder.Property(x => x.UpdatedID).IsRequired(false).HasMaxLength(36);
            builder.Property(x => x.UpdatedIPAddress).HasMaxLength(20).IsRequired(false);
            builder.Property(x => x.Status).IsRequired(true).HasDefaultValue(DataStatus.Unknown);
            //AspNetUser
            builder.Property(x => x.UserName).HasMaxLength(32).IsRequired(true);
            builder.Property(x => x.NormalizedUserName).HasMaxLength(32).IsRequired(false);
            builder.Property(x => x.Email).HasMaxLength(120).IsRequired(true);
            builder.Property(x => x.NormalizedEmail).HasMaxLength(120).IsRequired(false);
            builder.Property(x => x.PasswordHash).HasMaxLength(60).IsRequired(true);//BCrypt
            builder.Property(x => x.SecurityStamp).HasMaxLength(36).IsRequired(false);
            builder.Property(x => x.ConcurrencyStamp).HasMaxLength(36).IsRequired(false);
            builder.Property(x => x.PhoneNumber).HasMaxLength(11).IsRequired(true);
            builder.Property(x => x.LockoutEnd).IsRequired(false);

            //todo:BLL katmanında AspNet ile gelen nullable alanları doldur.


        }
    }
}
