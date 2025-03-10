using Data_Access.Entities.Abstracts;
using Data_Access.Entities.DriversVehicles;
namespace Data_Access.Entities.Vehicles
{
    public class Vehicle : BaseEntity
    {
        public string VehicleType { get; set; }
        public string Model { get; set; }
        public int Kilometer { get; set; }
        public int Age { get; set; }
        public short Capacity { get; set; }
        //Mapping
        public virtual ICollection<DriverVehicle> DriversVehicles { get; set; }
    }
}
