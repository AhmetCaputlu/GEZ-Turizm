using System.ComponentModel.DataAnnotations.Schema;
using Data_Access.Entities.Abstracts;
using Data_Access.Entities.Enums;
using Microsoft.AspNetCore.Identity;

namespace Data_Access.Entities.Employees
{
    public class Employee:BaseEntity
    {
        private ushort _DaysWorked;
        private DateTime _EndContract;
        public DateTime HireDate { get; set; }
        public DateTime EndContract { get { return EndContract.AddYears(1); }  }
        public ushort DaysWorked { get { return (ushort)(DateTime.Now - HireDate).TotalDays; }}
        public Department CurrentPosition { get; set; }
        //Mapping
        public EmployeeDetail EmployeeDetail { get; set; }
    }
}
