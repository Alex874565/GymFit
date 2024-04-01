namespace GymFit.Models
{
    public class Subscription
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public string? Description { get; set; }

        public List<Class> Classes { get; set; }

        public DateOnly StartDate { get; set; }

        public string Duration { get; set; }
    }
}