using Microsoft.EntityFrameworkCore;
using WebServiceProject.Data;
using WebServiceProject.Intefraces;
using WebServiceProject.Interfaces;
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

        // Récupérer tous les utilisateurs
        public ICollection<User> GetUsers()
        {
            return _dataContext.Users.OrderBy(u => u.Id).ToList();
        }

        // Récupérer un utilisateur par ID
        public User GetUserById(int id)
        {
            return _dataContext.Users.FirstOrDefault(u => u.Id == id);
        }

        // Créer un nouvel utilisateur
        public bool CreateUser(User user)
        {
            _dataContext.Users.Add(user);
            return Save();
        }

        // Mettre à jour un utilisateur existant
        public bool UpdateUser(User user)
        {
            _dataContext.Users.Update(user);
            return Save();
        }

        // Supprimer un utilisateur
        public bool DeleteUser(User user)
        {
            _dataContext.Users.Remove(user);
            return Save();
        }

        // Enregistrer les changements dans la base de données
        public bool Save()
        {
            return _dataContext.SaveChanges() > 0;
        }
    }
}
