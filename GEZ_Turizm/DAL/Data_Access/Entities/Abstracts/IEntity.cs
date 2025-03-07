using Data_Access.Entities.Enums;

namespace Data_Access.Entities.Abstracts
{
    public interface IEntity
    {
        public int ID { get; set; }//Kendi veritabınımızda benzersizlik olması amacıyla sayısal artışta olan ID
        public Guid UniqueIdentify { get; set; }//Dış sistemlerle veri çakışması yaşanmaması için tanımlanan ID
        public DateTime CreatedTime { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIPAdress { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public string? UpdatedComputerName { get; set; }
        public string? UpdatedIPAdress { get; set; }
        public DataStatus Status { get; set; }
        //Veri durumu sadece ilgili birimlerce görünecek.Müşteriler sadece Aktif Turları ve Etkinlikleri görebilecek

    }
}
