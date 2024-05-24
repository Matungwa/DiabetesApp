namespace DiabetesApp.Entities
{
    public class Prescription
    {
        public int Id { get; set; }

        public int PatientId { get; set; }
        public Patient? Patient { get; set; }
        public DateTime IssueDate { get; set; }

        public List<Medicine>? Medicines { get; set; }
    }
}
