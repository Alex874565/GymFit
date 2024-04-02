namespace GymFit.Models
{
    public class Trainer : User
    {
        private string Name { get; set; }

        private int Age { get; set; }

        private int Experience { get; set; }

        private string? Photo { get; set; }

        private string? Description { get; set; }
    }
}