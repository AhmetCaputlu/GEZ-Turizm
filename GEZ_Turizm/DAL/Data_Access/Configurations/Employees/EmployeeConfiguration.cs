using System.Security.Cryptography.X509Certificates;
using Data_Access.Configurations.Abstracts;
using Data_Access.Entities.Employees;
using Data_Access.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access.Configurations.Employees
{
    internal class EmployeeConfiguration : BaseEntityConfiguration<Employee>
    {
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.HireDate).IsRequired(true);
            builder.Property(x => x.EndContract).IsRequired(true);

        }
    }
}
