namespace DiabetesApp.Entities
{
    public class Hospital
    {
        public int Id { get; set; }

        public string hospital_name { get; set; } = string.Empty;

        // Navigation Properties
        public int DistrictId { get; set; }
        public int RegionId { get; set; }
        public District? District {  get; set; }
        public Region? Region { get; set; }
        public List<DoctorHospitalHistory>? DoctorHospitalHistories {  get; set; } 
        public List <PatientHospitalHistory>? PatientHospitalHistories { get; set; } 
    }
}
