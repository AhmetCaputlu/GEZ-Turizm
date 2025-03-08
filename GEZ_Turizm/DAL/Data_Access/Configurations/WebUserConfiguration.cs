using System.Diagnostics;
using Data_Access.Configurations.Abstracts;
using Data_Access.Entities;
using Data_Access.Entities.Abstracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access.Configurations
{
    internal class WebUserConfiguration : IEntityTypeConfiguration<WebUser>
    {
        public void Configure(EntityTypeBuilder<WebUser> builder)
        {
            #region Kod Tekrarı
            //WebUser Base Entity'den miras almadığı için bu property'ler yeniden yazıldı.
            builder.Property(x => x.CreatedComputerName).HasMaxLength(100);
            builder.Property(x => x.CreatedIPAddress).HasMaxLength(20);
            builder.Property(x => x.UpdatedComputerName).HasMaxLength(100);
            builder.Property(x => x.UpdatedIPAddress).HasMaxLength(20);
            #endregion

            builder.Property(x => x.UserName).HasMaxLength(46);
        }
    }
}
