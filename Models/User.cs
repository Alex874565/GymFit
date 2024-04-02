namespace GymFit.Models
{
    public enum Role { Admin, Client }

    public class User
    {
        private int Id { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private Role Role { get; set; }
    }
}
