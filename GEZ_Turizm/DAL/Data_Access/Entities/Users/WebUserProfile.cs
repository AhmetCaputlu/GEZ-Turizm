using Data_Access.Entities.Abstracts;
using Data_Access.Entities.Enums;

namespace Data_Access.Entities.Users
{
    public class WebUserProfile
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string TCN_PassportNumber { get; set; }
        public Tier UserTier { get; set; }
        public string PhotoPath { get; set; }
        public DateTime UpdatedDate { get; set; }
        //Mapping
        public int WebUserId { get; set; }
        public WebUser WebUser { get; set; }

    }
}
