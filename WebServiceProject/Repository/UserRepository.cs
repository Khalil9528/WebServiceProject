using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using WebServiceProject.Data;
using WebServiceProject.Intefraces;
using WebServiceProject.Models;

namespace WebServiceProject.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dataContext;

        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public ICollection<User> GetUsers()
        {
            return _dataContext.Users.OrderBy(u => u.Id).ToList();
        }
    }
}
