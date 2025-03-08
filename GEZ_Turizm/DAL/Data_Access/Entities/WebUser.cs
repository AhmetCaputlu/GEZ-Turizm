using System.ComponentModel.DataAnnotations.Schema;
using Data_Access.Entities.Abstracts;
using Data_Access.Entities.Enums;
using Microsoft.AspNetCore.Identity;

namespace Data_Access.Entities
{
    public class WebUser : IdentityUser<int>, IEntity
        //Kayıt yapan veya güncellenen kullanıcıların ID,IP ve bilgisayar adı alınmayacak.
        //Bu property'ler şirket içi çalışanları takip edebilmek amacıyla var çünkü.(Sadece Created time bilgisi alınacak)
        //Ancak kullanıcı taraflı değil de yetkilendireceğim idari birim tarafından bir güncelleme yapılırsa kaydedilecek.(BLL)
    {
        //Email
        //Şifre
        //TelNo halihazırda geliyor.
        [NotMapped]//IdentityUser'dan gelen int Id kullanılacağı için bu olmamalı
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

        //Ek özellikler
        public string UserName { get; set; }
        //Mapping
        public WebUserProfile WebUserProfile { get; set; }
    }
}
