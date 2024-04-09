namespace GymFit.Models
{
    public class Subscription
    {
        private string? Name { get; set; }

        private int? Price { get; set; }

        private string? Description { get; set; }

        private List<Class>? Classes { get; set; }

        private DateOnly StartDate { get; set; }

        private string? Duration { get; set; }
    }
}