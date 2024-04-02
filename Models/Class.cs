namespace GymFit.Models
{
    public class Class
    {
        private int id {  get; set; }

        private string Name { get; set; }

        private int Duration { get; set; }

        private Trainer Trainer { get; set; }

        private string? Description { get; set; }

        private int Capacity { get; set; }
    }
}