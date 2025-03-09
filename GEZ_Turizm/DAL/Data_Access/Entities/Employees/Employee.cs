using System.ComponentModel.DataAnnotations.Schema;
using Data_Access.Entities.Abstracts;
using Data_Access.Entities.Enums;
using Microsoft.AspNetCore.Identity;

namespace Data_Access.Entities.Employees
{
    public class Employee : IdentityUser<int>, IEntity
    {
        public int CustomID { get; set; }
        public string UniqueIdentify { get; set; }
        public DateTime CreatedTime { get; set; }
        public Guid CreatedID { get; set; }
        public string CreatedIPAddress { get; set; }
        public DateTime UpdatedTime { get; set; }
        public Guid UpdatedID { get; set; }
        public string UpdatedIPAddress { get; set; }
        public DataStatus Status { get; set; }
        //Custom Properties
        public DateTime HireDate { get; set; }
        public DateTime EndContract { get; set; }
        public ushort DaysWorked { get; set; }
        public Department CurrentDepartment { get; set; }
        //Mapping
        public EmployeeDetail EmployeeDetail { get; set; }
    }
}
