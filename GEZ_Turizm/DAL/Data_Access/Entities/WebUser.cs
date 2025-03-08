using System.ComponentModel.DataAnnotations.Schema;
using Data_Access.Entities.Abstracts;
using Data_Access.Entities.Enums;
using Microsoft.AspNetCore.Identity;

namespace Data_Access.Entities
{
    public class WebUser : IdentityUser<Guid>, IEntity
        //Kayıt yapan veya güncellenen kullanıcıların ID,IP ve bilgisayar adı alınmayacak.
        //Bu property'ler şirket içi çalışanları takip edebilmek amacıyla var çünkü.(Sadece Created time bilgisi alınacak)
        //Ancak kullanıcı taraflı değil de yetkilendireceğim idari birim tarafından bir güncelleme yapılırsa kaydedilecek.(BLL)
    {
        //Email
        //Şifre
        //TelNo halihazırda geliyor.
        public int CustomID { get; set; }
        [NotMapped]//Identity User ile miras yoluyla GUID tipinde bir Id alacağımız için buna WebUser nesnesinde ihtiyacımız yok.
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

        //Ek özellikler
        public string UserName { get; set; }
        //Mapping
        public WebUserProfile WebUserProfile { get; set; }
    }
}//todo:Kullanıcı ve kullanıcı profiliyle çalışma kolaylığı olması için CustomId propertylerini kullanıyoruz.BLL katmanında aktarma yapılması gerekicek.Örn 184 Custom Id'si olan kullanıcının Profilinin de CustomId'si 184 olmalı.Sadece bir tabloda bir PK olabildiği için Custom Id eşlenemedi (BLL)
