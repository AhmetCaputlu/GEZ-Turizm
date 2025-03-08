using Data_Access.Entities.Abstracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access.Configurations.Abstracts
{
    internal class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.CreatedComputerName).HasMaxLength(100);
            builder.Property(x => x.CreatedIPAddress).HasMaxLength(20);
            builder.Property(x => x.UpdatedComputerName).HasMaxLength(100);
            builder.Property(x => x.UpdatedIPAddress).HasMaxLength(20);

        }
    }
}
