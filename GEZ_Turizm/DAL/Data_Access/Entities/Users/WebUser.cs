using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using Data_Access.Entities.Abstracts;
using Data_Access.Entities.Enums;
using Microsoft.AspNetCore.Identity;

namespace Data_Access.Entities.Users
{
    public class WebUser : IdentityUser<int>, IEntity
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
        //Mapping
        public WebUserProfile WebUserProfile { get; set; }
    }
}