using Data_Access.Entities.Employees;
using Data_Access.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access.Configurations.Employees
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.CustomID);
            builder.Property(x => x.CustomID).IsRequired(true).UseIdentityColumn(1, 1);
            builder.Property(x => x.UniqueIdentify).HasMaxLength(40).IsRequired(true).HasDefaultValue(Guid.NewGuid().ToString());
            builder.Property(x => x.CreatedTime).IsRequired(true).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedID).IsRequired(true).HasDefaultValue(Guid.NewGuid().ToString());
            //todo:Kayıt oluşturan kullanıcının Guid bilgisi atanacak.
            builder.Property(x => x.CreatedIPAddress).HasMaxLength(20).IsRequired(true).HasDefaultValue("");
            //todo:BLL katmanında kullanıcının IP bilgisi alınacak.(HttpContext)
            builder.Property(x => x.UpdatedTime).IsRequired(false);
            builder.Property(x => x.UpdatedID).IsRequired(false);
            builder.Property(x => x.UpdatedIPAddress).HasMaxLength(20).IsRequired(false);
            builder.Property(x => x.Status).IsRequired(true).HasDefaultValue(DataStatus.Unknown);
        }
    }
}
