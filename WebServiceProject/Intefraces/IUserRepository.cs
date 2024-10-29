using WebServiceProject.Models;

namespace WebServiceProject.Intefraces
{
    public interface IUserRepository
    {
        ICollection<User> GetUsers();   
      
    }
}
