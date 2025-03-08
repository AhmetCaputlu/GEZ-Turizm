using Data_Access.Entities.Abstracts;
using Data_Access.Entities.Enums;

namespace Data_Access.Entities.Employees
{
    public class EmployeeDetail:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public byte Age { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string? PhotoPath { get; set; }
        //Mapping   
        public Employee Employee { get; set; }

    }
}
