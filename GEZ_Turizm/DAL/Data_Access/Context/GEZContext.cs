using Data_Access.Configurations.Drivers;
using Data_Access.Configurations.DriversVehicles;
using Data_Access.Configurations.Employees;
using Data_Access.Configurations.Vehicles;
using Data_Access.Configurations.WebUsers;
using Data_Access.Entities.DriversVehicles;
using Data_Access.Entities.Employees;
using Data_Access.Entities.Users;
using Data_Access.Entities.Vehicles;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

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
        public DbSet<WebUser> AspNetUsers { get; set; }
        public DbSet<WebUserProfile> AspNetUserProfiles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<DriverVehicle> Drivers_Vehicles { get; set; }





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
            modelbuilder.ApplyConfiguration(new WebUserProfileConfiguration());
            modelbuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelbuilder.ApplyConfiguration(new EmployeeDetailConfiguration());
            modelbuilder.ApplyConfiguration(new DriverConfiguration());
            modelbuilder.ApplyConfiguration(new VehicleConfiguration());
            modelbuilder.ApplyConfiguration(new DriverVehicleConfiguration());
            
            base.OnModelCreating(modelbuilder);
        }
    }
}
