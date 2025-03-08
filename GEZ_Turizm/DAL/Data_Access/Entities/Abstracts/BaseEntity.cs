using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using Data_Access.Entities.Enums;
using Data_Access.Helpers;

namespace Data_Access.Entities.Abstracts
{
    public abstract class BaseEntity : IEntity
    {
        public BaseEntity()
        {
            UniqueIdentify = Guid.NewGuid();
            CreatedTime = DateTime.Now;
            CreatedIPAddress = IpAdress.GetIpAddress();
            CreatedComputerName = Environment.MachineName;
        }//Güncellenecek
        public int CustomID { get; set; }
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
    }
}
