using System.ComponentModel.DataAnnotations;

namespace DiabetesApp.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string username { get; set; } = string.Empty;
        public string full_name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

        // Soft Delete
        public bool IsDeleted { get; set; }

        // Auditing fields
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Navigation properties
        public int RoleId { get; set; }
        public int GenderId { get; set; }
        public int? DoctorInfoId { get; set; }
        public int? HospitalId { get; set; }    
        public Role? Role { get; set; }
        public Gender? Gender { get; set; }
        public DoctorInfo? DoctorInfo { get; set; } 
        public Hospital? Hospital { get; set; } 
        public List<PatientObservation>? PatientObservations { get; set; }
        public List<DoctorHospitalHistory>? DoctorHospitalHistories { get; set; }
    }
}
