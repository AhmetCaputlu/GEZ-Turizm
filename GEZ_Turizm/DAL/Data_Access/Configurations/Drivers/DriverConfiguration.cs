using Data_Access.Configurations.Abstracts;
using Data_Access.Entities.Employees;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access.Configurations.Drivers
{
    internal class DriverConfiguration:BaseEntityConfiguration<Driver>
    {
        public override void Configure(EntityTypeBuilder<Driver> builder)
        {
            base.Configure(builder);

            
            builder.Property(x => x.FirstName).HasMaxLength(30).IsRequired(true);
            builder.Property(x => x.LastName).HasMaxLength(30).IsRequired(true);
            builder.Property(x => x.DriverLicense).HasMaxLength(10).IsRequired(true);
            builder.Property(x => x.Age).IsRequired(true);


        }
    }
}
