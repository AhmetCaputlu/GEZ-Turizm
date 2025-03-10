using Data_Access.Entities.Employees;
using Data_Access.Entities.Vehicles;

namespace Data_Access.Entities.DriversVehicles
{
    public class DriverVehicle
    {
        public int DriverId { get; set; }
        public Driver Driver { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
