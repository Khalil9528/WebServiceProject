using WebServiceProject.Data;
using WebServiceProject.Intefraces;
using WebServiceProject.Models;

namespace WebServiceProject.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly DataContext _context;
        public MovieRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Movie> GetMovies()
        {
            return _context.Movies.OrderBy(m => m.Id).ToList();
        }

        public Movie GetMovieById(int id)
        {
            return _context.Movies.Where(m => m.Id == id).FirstOrDefault();
        }

        public Movie GetMovieByTitle(string title)
        {
            return _context.Movies.Where(m => m.Title == title).FirstOrDefault();
        }

        // Méthode pour ajouter un film
        public bool AddMovie(Movie movie)
        {
            // Ajout du film au contexte
            _context.Movies.Add(movie);

            // Sauvegarde des changements
            return Save();
        }

        // Méthode pour sauvegarder les modifications dans la base de données
        public bool Save()
        {
            // Retourne true si une ou plusieurs lignes ont été affectées (changement sauvegardé avec succès)
            return _context.SaveChanges() > 0;
        }
    }
}
