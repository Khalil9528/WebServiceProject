using System.Data;

namespace WebServiceProject.Models
{
    public enum Role
    {
        User = 0,
        Admin = 1
    }
    public class User
    {
        public int Id { get; set; }
        public string Pseudo { get; set; }
        public string Password { get; set; }
        public Role UserRole { get; set; }
        public ICollection<Review> Reviews { get; set; }


        public User()
        {
            Pseudo = string.Empty;
            Password = string.Empty;
            Reviews = new List<Review>(); // Initialisation pour éviter les références nulles
        }
    }

}
