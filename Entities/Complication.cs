namespace DiabetesApp.Entities
{
    public class Complication
    {
        public int Id { get; set; }

        public string complication_type { get; set; } = string.Empty;
        public string complication_name { get; set; } = string.Empty;
        public string complication_code { get; set; } = string.Empty;

        // Navigation Proprties
        public int PatientId { get; set; }
        public Patient? Patient { get; set; }
        public List<PatientObservation>? PatientObservations { get; set; }
    }
}
