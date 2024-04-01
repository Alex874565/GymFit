namespace GymFit.Models
{
    public class Class
    {
        public string Name { get; set; }

        public DateOnly Date { get; set; }

        public int Duration { get; set; }

        public Trainer Trainer { get; set; }

        public string? Description { get; set; }

        public int ClientNo { get; set; }

        public int MaxNo { get; set; }
    }
}