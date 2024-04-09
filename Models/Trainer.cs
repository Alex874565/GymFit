namespace GymFit.Models
{
    public class Trainer : User
    {
        private string Name { get; set; }

        private int Age { get; set; }

        private int Experience { get; set; }

        private string? Photo { get; set; }

        private string? Description { get; set; }

        public Trainer(string name, int age, int experience, string email, string password, string? photo, string? description) : base(email, password)
        {
            Name = name;
            Age = age;
            Experience = experience;
            Photo = photo;
            Description = description;
        }
    }
}