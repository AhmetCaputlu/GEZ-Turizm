using Data_Access.Entities.DriversVehicles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access.Configurations.DriversVehicles
{
    internal class DriverVehicleConfiguration : IEntityTypeConfiguration<DriverVehicle>
    {
        public void Configure(EntityTypeBuilder<DriverVehicle> builder)
        {
            builder.HasKey(x => new { x.DriverId, x.VehicleId });
            builder.HasOne(x => x.Vehicle).WithMany(x => x.DriversVehicles).HasForeignKey(x => x.VehicleId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Driver).WithMany(x => x.DriversVehicles).HasForeignKey(x => x.DriverId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
