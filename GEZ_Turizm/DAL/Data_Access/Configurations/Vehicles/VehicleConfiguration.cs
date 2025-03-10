using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access.Configurations.Abstracts;
using Data_Access.Entities.Vehicles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access.Configurations.Vehicles
{
    internal class VehicleConfiguration :BaseEntityConfiguration<Vehicle>
    {
        public override void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            base.Configure(builder);

            
            builder.Property(x=>x.VehicleType).HasMaxLength(50).IsRequired(true);
            builder.Property(x=>x.Model).HasMaxLength(200).IsRequired(false);
            builder.Property(x=>x.Kilometer).HasMaxLength(7).IsRequired(true);
            builder.Property(x=>x.Age).HasMaxLength(2).IsRequired(true);
            builder.Property(x=>x.Capacity).HasMaxLength(2).IsRequired(true);
        }
    }
}
