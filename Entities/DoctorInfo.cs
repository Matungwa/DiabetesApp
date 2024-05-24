namespace DiabetesApp.Entities
{
    public class DoctorInfo
    {
        public int Id { get; set; }
        public bool is_trained { get; set; }
        public string trainer_name { get; set; } = string.Empty;
        public DateTime TrainingDate { get; set; }

        public List<User>? Users { get; set; }    
           
    }
}
