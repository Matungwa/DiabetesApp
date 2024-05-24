using DiabetesApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace DiabetesApp.Data
{
	public class AppDbContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Role> Roles { get; set; }
        public DbSet<Complication> Complications { get; set; }
		public DbSet<District> Districts { get; set; }
		public DbSet<DoctorHospitalHistory> DoctorHospitalHistories { get; set; }	
		public DbSet<DoctorInfo> DoctorInfo { get; set; }
		public DbSet<Gender> Gender { get; set; }	
		public DbSet<Hospital> Hospitals { get; set; }	
		public DbSet<Medicine> Medicines { get; set; }	
		public DbSet<Patient> Patients { get; set; }	
		public DbSet<PatientHospitalHistory> PatientHospitalHistories { get; set; }
		public DbSet<PatientObservation> PatientObservations { get; set; }	
		public DbSet<Prescription> Prescriptions { get; set; }	
		public DbSet<Region> Regions { get; set; }	
		
		

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
		{
			
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Data Seeding
			modelBuilder.Entity<Role>().HasData(
				new Role { Id =  1, Name = "Admin"},
				new Role { Id = 2, Name = "Doctor" },
				new Role { Id = 3, Name = "Head Of Clinic" },
				new Role { Id = 4, Name = "TDAPersonnel" }
				);

			base.OnModelCreating(modelBuilder);
		}
	}
}
