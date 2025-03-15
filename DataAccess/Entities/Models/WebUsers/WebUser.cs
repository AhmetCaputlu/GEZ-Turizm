using DataAccess.Entities.Enums;
using DataAccess.Entities.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace DataAccess.Entities.Models.WebUsers
{
    public class WebUser : IdentityUser<int>, IEntity
    {
        public string Guid { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedID { get; set; }
        public string CreatedIPAddress { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedID { get; set; }
        public string? UpdatedIPAddress { get; set; }
        public DataStatus Status { get; set; }
    }
}
