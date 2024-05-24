namespace DiabetesApp.Entities
{
    public class District
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // Navigation Properties
        public int DistrictId { get; set; }
        public Region? Region { get; set; }
        public List<Hospital>? Hospitals { get; set; }
    }
}
