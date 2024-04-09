namespace GymFit.Models
{
    public class Client : User
    {
        private string Name { get; set; }

        private Subscription? Subscription { get; set; }

        public Client(string name, Subscription? subscription, string email, string password) : base(email, password)
        {
            Name = name;
            Subscription = subscription;
        }
    }
}
