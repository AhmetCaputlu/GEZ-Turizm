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
            CreatedIPAdress = IpAdress.GetIpAddress();
            CreatedComputerName = Environment.MachineName;
        }//Güncellenecek
        public int ID { get; set; }
        public Guid UniqueIdentify { get; set; }

        //Diğerleri IEntity'den miras yoluyla gelenler
        public DateTime CreatedTime { get; set; }
        public Guid CreatedID { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIPAdress { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public Guid? UpdatedID { get; set; }
        public string? UpdatedComputerName { get; set; }
        public string? UpdatedIPAdress { get; set; }
        public DataStatus Status { get; set; }
    }
}
