using Data_Access.Entities.Employees;
using Data_Access.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            #region Kod Tekrarı
            //WebUser Base Entity'den miras almadığı için bu property'ler yeniden yazıldı.
            builder.Property(x => x.CreatedComputerName).HasMaxLength(100);
            builder.Property(x => x.CreatedIPAddress).HasMaxLength(20);
            builder.Property(x => x.UpdatedComputerName).HasMaxLength(100);
            builder.Property(x => x.UpdatedIPAddress).HasMaxLength(20);
            #endregion


        }
    }
}
