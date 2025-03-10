﻿using Data_Access.Entities.Abstracts;
using Data_Access.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access.Configurations.Abstracts
{
    internal class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.CustomID);
            builder.Property(x => x.CustomID).IsRequired(true).UseIdentityColumn(1,1);
            builder.Property(x => x.UniqueIdentify).HasMaxLength(36).IsRequired(true).HasDefaultValue(Guid.NewGuid().ToString());
            builder.Property(x => x.CreatedTime).IsRequired(true).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedID).HasMaxLength(36).IsRequired(true).HasDefaultValue(Guid.NewGuid().ToString());
            //todo:Kayıt oluşturan kullanıcının Guid bilgisi atanacak.
            builder.Property(x => x.CreatedIPAddress).HasMaxLength(20).IsRequired(true).HasDefaultValue("");
            //todo:BLL katmanında kullanıcının IP bilgisi alınacak.(HttpContext)
            builder.Property(x => x.UpdatedTime).IsRequired(false);
            builder.Property(x => x.UpdatedID).HasMaxLength(36).IsRequired(false);
            builder.Property(x => x.UpdatedIPAddress).HasMaxLength(20).IsRequired(false);
            builder.Property(x => x.Status).IsRequired(true).HasDefaultValue(DataStatus.Unknown);
            

        }
    }
}
