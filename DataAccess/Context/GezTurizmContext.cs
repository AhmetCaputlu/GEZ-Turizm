using DataAccess.Configurations.WebUsers;
using DataAccess.Entities.Models.WebUsers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class GezTurizmContext : IdentityDbContext<WebUser,IdentityRole<int>,int>
    {
        public GezTurizmContext()
        {

        }
        public GezTurizmContext(DbContextOptions<GezTurizmContext> options) : base(options)
        {

        }

        public DbSet<WebUser> AspNetUsers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer
                    ("Server=DESKTOP-10C2B34\\SQLEXPRESS;Database=GEZTurizmDB;uid=sa;pwd=123456;TrustServerCertificate=true;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WebUserConfiguration());

            base.OnModelCreating(modelBuilder);
        }



    }
}
