using Data_Access.Entities.Employees;
using Data_Access.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access.Configurations.Employees
{
    internal class EmployeeDetailConfiguration : IEntityTypeConfiguration<EmployeeDetail>
    {
        public void Configure(EntityTypeBuilder<EmployeeDetail> builder)
        {
            builder.HasKey(x => x.EmployeeId);
            builder.HasOne(x=>x.Employee).WithOne(x=>x.EmployeeDetail).HasForeignKey<EmployeeDetail>(x=>x.EmployeeId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(x => x.FirstName).HasMaxLength(30).IsRequired(true);
            builder.Property(x => x.LastName).HasMaxLength(30).IsRequired(true);
            builder.Property(x => x.Gender).IsRequired(true).HasDefaultValue(Gender.Unknown);
            builder.Property(x => x.Address).HasMaxLength(150).IsRequired(true).HasDefaultValue("Adres Bilgisi Düzenlenmedi");
            builder.Property(x => x.Age).IsRequired(true).HasDefaultValue(0);
            builder.Property(x => x.PhotoPath).HasMaxLength(255).IsRequired(false);


        }
    }
}
