using System.Net;
using Data_Access.Entities.Abstracts;
using Data_Access.Entities.Enums;

namespace Data_Access.Entities
{
    public class BaseEntity : IEntity
    {
        public BaseEntity()
        {
            UniqueIdentify = Guid.NewGuid();
            CreatedTime = DateTime.Now;
            CreatedIPAdress = "";//Güncellenecek
            CreatedComputerName = "";//Güncellenecek
        }

        public int ID { get; set; }
        public Guid UniqueIdentify { get; set; }
        public DateTime CreatedTime { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIPAdress { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public string? UpdatedComputerName { get; set; }
        public string? UpdatedIPAdress { get; set; }
        public DataStatus Status { get; set; }
    }
}
