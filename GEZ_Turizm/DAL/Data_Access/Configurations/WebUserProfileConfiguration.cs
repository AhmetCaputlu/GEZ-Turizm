using Data_Access.Configurations.Abstracts;
using Data_Access.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access.Configurations
{
    internal class WebUserProfileConfiguration:BaseEntityConfiguration<WebUserProfile>
    {
        public override void Configure(EntityTypeBuilder<WebUserProfile> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(40);
            builder.Property(x => x.LastName).HasMaxLength(50);
            builder.Property(x => x.PhoneNumber).HasMaxLength(11);
            builder.Property(x => x.TCN_PassportNumber).HasMaxLength(11);//Pasaport zaten maks 10 karakter olabilir.TC No baz alındı.
            builder.Property(x => x.PhotoPath).HasMaxLength(255);
            //Mapping
            builder.HasKey(x => x.UniqueIdentify);

            builder.HasOne(x => x.WebUser).WithOne(x => x.WebUserProfile).HasForeignKey<WebUserProfile>(x => x.UniqueIdentify).OnDelete(DeleteBehavior.NoAction);
            
            base.Configure(builder);   
        }
    }
}
