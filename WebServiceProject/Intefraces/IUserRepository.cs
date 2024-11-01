using WebServiceProject.Models;

namespace WebServiceProject.Interfaces
{
    public interface IUserRepository
    {
        // Récupère tous les utilisateurs
        ICollection<User> GetUsers();

        // Récupère un utilisateur par son ID
        User GetUserById(int id);

        // Crée un nouvel utilisateur
        bool CreateUser(User user);

        // Met à jour un utilisateur existant
        bool UpdateUser(User user);

        // Supprime un utilisateur
        bool DeleteUser(User user);

        // Sauvegarde les changements dans la base de données
        bool Save();
    }
}
