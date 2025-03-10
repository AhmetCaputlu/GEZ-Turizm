using Data_Access.Entities.Abstracts;
using Data_Access.Entities.DriversVehicles;

namespace Data_Access.Entities.Employees
{
    public class Driver:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DriverLicense { get; set; }
        public short Age { get; set; }
        //Mapping
        public virtual ICollection<DriverVehicle> DriversVehicles { get; set; }
    }
}
