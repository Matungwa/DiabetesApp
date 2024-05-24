namespace DiabetesApp.Entities
{
    public class DoctorHospitalHistory
    {
        public int Id { get; set; } //primary key

        //foreign keys
        public int UserId { get; set; }
        public int HospitalId { get; set; }

        public DateTime date_joined { get; set; }
        public DateTime date_left { get; set; }

        // Navigation property to its foreign keys
        public  Hospital? Hospital { get; set; }
        public  User? User { get; set; }
    }
}

