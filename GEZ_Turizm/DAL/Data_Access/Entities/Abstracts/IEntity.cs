using Data_Access.Entities.Enums;

namespace Data_Access.Entities.Abstracts
{
    public interface IEntity
    {
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
        //Veri durumu sadece ilgili birimlerce görünecek.Müşteriler sadece Aktif Turları ve Etkinlikleri görebilecek
    }
}
