namespace GymFit.Models
{
    public class Client : User
    {
        private string Name { get; set; }

        private Subscription? Subscription { get; set; }
    }
}
