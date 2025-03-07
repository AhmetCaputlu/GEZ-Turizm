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
        public DateTime CreatedTime { get; set; }      
        public Guid CreatedID { get; set; } 
        public string CreatedComputerName { get; set; }        
        public string CreatedIPAdress { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public Guid? UpdatedID { get; set; }
        public string? UpdatedComputerName { get; set; }
        public string? UpdatedIPAdress { get; set; }
        public DataStatus Status { get; set; }

        //Ek özellikler
        public string UserName { get; set; }
        //Mapping
    }
}
