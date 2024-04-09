using System.Text.Json.Serialization;

namespace GymFit.Models
{
    public enum Role { Admin, Client }

    public class User
    {
        protected int? Id { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        protected Role? Role { get; set; }

        public User() { }

        [JsonConstructor]
        public User(string email, string password) {
            Email = email;
            Password = password;
        }

        public string getEmail() {  return Email; }

        public string getPassword() { return Password; }

        public void setEmail(string Email) { this.Email = Email;}

        public void setPassword(string Password) {  this.Password = Password;}
    }
}
