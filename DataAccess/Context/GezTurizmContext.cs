using DataAccess.Entities.Models.WebUsers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class GezTurizmContext : IdentityDbContext<WebUser,IdentityRole<int>,int>
    {
        public GezTurizmContext(DbContextOptions<GezTurizmContext> options) : base(options)
        {
        }

        public GezTurizmContext()
        {
        }




    }
}
