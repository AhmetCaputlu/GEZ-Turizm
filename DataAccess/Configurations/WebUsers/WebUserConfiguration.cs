using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.WebUsers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.WebUsers
{
    internal class WebUserConfiguration : IEntityTypeConfiguration<WebUser>
    {
        public void Configure(EntityTypeBuilder<WebUser> builder)
        {
            //IEntity
            builder.Ignore(x => x.Id);
            builder.Property(x => x.Guid).HasMaxLength(36).IsRequired(true).HasDefaultValue(Guid.NewGuid().ToString());
            builder.Property(x => x.CreatedDate).IsRequired(true).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedID).IsRequired(true).HasMaxLength(36).HasDefaultValue(Guid.NewGuid().ToString());
            //todo:Kayıt oluşturan kullanıcının Guid bilgisi atanacak.
            builder.Property(x => x.CreatedIPAddress).HasMaxLength(20).IsRequired(true).HasDefaultValue("");
            //todo:BLL katmanında kullanıcının IP bilgisi alınacak.(HttpContext)
            builder.Property(x => x.UpdatedDate).IsRequired(false);
            builder.Property(x => x.UpdatedID).IsRequired(false).HasMaxLength(36);
            builder.Property(x => x.UpdatedIPAddress).HasMaxLength(20).IsRequired(false);
            builder.Property(x => x.Status).IsRequired(true).HasDefaultValue(DataStatus.Unknown);
            
            //AspNetUser
            #region Fluent API ile yapılandırma Migration'a yansımıyor.
            //Email ve Kullanıcı Adı ya ilgili attribute yüzünden yapılandırılamıyor ya da
            //usermanager.createasync(user,password); metodundan kaynaklı 

            //builder.Property(x => x.UserName).HasMaxLength(32).IsRequired(true);
            //builder.Property(x => x.NormalizedUserName).HasMaxLength(32).IsRequired(false);
            //builder.Property(x => x.Email).HasMaxLength(120).IsRequired(true);
            //builder.Property(x => x.NormalizedEmail).HasMaxLength(120).IsRequired(false); 
            #endregion

            builder.Property(x => x.PasswordHash).HasMaxLength(60).IsRequired(true);//BCrypt
            builder.Property(x => x.SecurityStamp).HasMaxLength(36).IsRequired(false);
            builder.Property(x => x.ConcurrencyStamp).HasMaxLength(36).IsRequired(false);
            builder.Property(x => x.PhoneNumber).HasMaxLength(11).IsRequired(true);
            builder.Property(x => x.LockoutEnd).IsRequired(false);

            //todo:BLL katmanında AspNet ile gelen nullable alanları doldur.
        }
    }
}
