using Data_Access.Configurations.Abstracts;
using Data_Access.Entities.Employees;
using Data_Access.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access.Configurations
{
    internal class EmployeeDetailConfiguration:BaseEntityConfiguration<EmployeeDetail>
    {
        public override void Configure(EntityTypeBuilder<EmployeeDetail> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(40);
            builder.Property(x => x.LastName).HasMaxLength(50);
            builder.Property(x => x.PhoneNumber).HasMaxLength(11);
            builder.Property(x => x.PhotoPath).HasMaxLength(255);

            builder.HasKey(x => x.UniqueIdentify);
            builder.HasOne(x => x.Employee).WithOne(x => x.EmployeeDetail).HasForeignKey<EmployeeDetail>(x => x.UniqueIdentify).OnDelete(DeleteBehavior.NoAction);
            
        }
    }
}
