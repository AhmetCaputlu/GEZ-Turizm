using Data_Access.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Data_Access.Context
{
    public class GEZContext:IdentityDbContext<WebUser,IdentityRole<Guid>,Guid>
        //Varsayılan string olduğu için düzenleme gerekiyor
    {
        public GEZContext()
        {
            //Instance alırken kullanılabilir.
        }
        public GEZContext(DbContextOptions<GEZContext> options):base(options)
        {
            //Servis kullanırken bu kullanılabilir.
        }
        public DbSet<WebUser> Users { get; set; }
        public DbSet<WebUserProfile> UserDetails { get; set; }

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
            

            base.OnModelCreating(modelbuilder);
        }
    }
}
