namespace DiabetesApp.Entities
{
    public class Patient
    {
        public int Id { get; set; } //primary key

        public string patient_reg_no { get; set; } = string.Empty;
        public string patient_name { get; set; } = string.Empty;
        public string residence { get; set; } = string.Empty;
        public int GenderId { get; set; }
        public Gender? Gender { get; set; }
        public List<Prescription>? Prescriptions { get; set; }
        public List<PatientHospitalHistory>? patientHospitalHistories { get; set; }

    }
}
