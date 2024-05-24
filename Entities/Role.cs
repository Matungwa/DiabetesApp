namespace DiabetesApp.Entities
{
	public class Role
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;

		// Nsvigation property
		public List<User>? Users { get; set; }
	}
}
