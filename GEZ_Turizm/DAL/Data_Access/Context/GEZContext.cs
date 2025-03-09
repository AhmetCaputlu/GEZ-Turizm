using Data_Access.Configurations;
using Data_Access.Configurations.Abstracts;
using Data_Access.Entities.Abstracts;
using Data_Access.Entities.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Data_Access.Context
{
    public class GEZContext:IdentityDbContext<WebUser,IdentityRole<int>,int>
    {
        public GEZContext()
        {

        }
        public GEZContext(DbContextOptions<GEZContext> options):base(options)
        {

        }
        public DbSet<WebUser> Users { get; set; }
        public DbSet<WebUserProfile> AspNetUserProfiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer
                    ("Server=DESKTOP-10C2B34\\SQLEXPRESS;Database=GEZTurizmDB;uid=sa;pwd=123456;TrustServerCertificate=true;");
            }

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new WebUserConfiguration());
            
            base.OnModelCreating(modelbuilder);
        }
    }
}
