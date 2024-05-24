namespace DiabetesApp.Entities
{
    public class PatientObservation
    {
        public int Id { get; set; }
        public string HBA1C { get; set; } = string.Empty;
        public string FBG { get; set; } = string.Empty;
        public string RBG { get; set; } = string.Empty ;
        public int height { get; set; }
        public int weight { get; set; }
        public int BMI { get; set; }
        public DateTime Observation_Date { get; set; }

        // Navigation Properties
        public int PatientId { get; set; }
        public int HospitalId { get; set; }
        public Patient? Patient { get; set; }
        public Hospital? Hospital { get; set; }
    }
}
