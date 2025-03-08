using Data_Access.Entities.Abstracts;
using Data_Access.Entities.Enums;

namespace Data_Access.Entities
{
    public class WebUserProfile:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TCN_PassportNumber{ get; set; }//Kimlik numarası veya pasaport bilgileri
        public Tier UserTier { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string PhotoPath { get; set; }
        //Mapping
        public WebUser WebUser { get; set; }

    }
}
