namespace DiabetesApp.Entities
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;

        public List<Prescription>? Prescriptions { get; set; }
    }
}
