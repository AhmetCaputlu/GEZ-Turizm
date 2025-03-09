using Data_Access.Entities.Enums;

namespace Data_Access.Entities.Abstracts
{
    public interface IEntity
    {
        public int CustomID { get; set; }
        public string UniqueIdentify { get; set; }
        public DateTime CreatedTime { get; set; }
        public string CreatedID { get; set; }
        public string CreatedIPAddress { get; set; }       
        public DateTime? UpdatedTime { get; set; }
        public string UpdatedID { get; set; }
        public string UpdatedIPAddress { get; set; }
        public DataStatus Status { get; set; }
       
    }
}
