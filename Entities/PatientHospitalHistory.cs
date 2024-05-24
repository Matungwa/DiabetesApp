namespace DiabetesApp.Entities
{
    public class PatientHospitalHistory
    {
        public int Id { get; set; }

        //foreign keys
        public int PatientId { get; set; }
        public int HospitalId { get; set; }

        public DateTime date_joined { get; set; }
        public DateTime date_left { get; set; }

        // Navigation property to its foreign keys
        public Hospital? Hospital { get; set; }
        public Patient? Patient { get; set; }

    }
}
