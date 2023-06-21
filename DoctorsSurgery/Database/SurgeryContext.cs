using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;
using DoctorsSurgery.Entities;
using Microsoft.Extensions.Configuration;

namespace DoctorsSurgery.Database
{
    public class SurgeryContext : DbContext
    {
        public DbSet<IPatient> Patients { get; set; } 
        public DbSet<IDoctor> Doctors { get; set; }
        public DbSet<ISlot> Slots { get; set; }  
        public DbSet<IAppointment> Appointments { get; set; } 

        public string DbPath { get; }

        public SurgeryContext(DbContextOptions<SurgeryContext> options) : base(options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "surgery.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

    }


    public static class DbExtension
    {
        public static IServiceCollection AddSurgeryDb(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<SurgeryContext>(options => options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
