using System.ComponentModel.DataAnnotations.Schema;
using Data_Access.Entities.Abstracts;
using Data_Access.Entities.Enums;
using Microsoft.AspNetCore.Identity;

namespace Data_Access.Entities.Employees
{
    public class Employee : IdentityUser<Guid>, IEntity
    {
        public int CustomID { get; set; }
        [NotMapped]
        public Guid UniqueIdentify { get; set; }
        public DateTime CreatedTime { get; set; }
        public Guid CreatedID { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIPAddress { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public Guid? UpdatedID { get; set; }
        public string? UpdatedComputerName { get; set; }
        public string? UpdatedIPAddress { get; set; }
        public DataStatus Status { get; set; }
        //Employee Sınıfına Özgü özellikler
        public DateTime HireDate { get; set; }
        public DateTime EndContract { get; set; }//sözleşmesinin bitiş tarihi
        public ulong DaysWorked { get; set; }//Kaç gündür çalıştığına dair direkt bir gösterim
        public Department CurrentDepartment { get; set; }//Hangi birimin çalışanı
        //Mapping
        public EmployeeDetail EmployeeDetail { get; set; }
    }
}
