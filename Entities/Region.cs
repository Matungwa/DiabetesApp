namespace DiabetesApp.Entities
{
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<District>? Districts { get; set; }
        public List<Hospital>? Hospitals { get; set;}
    }
}
