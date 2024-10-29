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
            {
                return _context.Movies.Where(m => m.Title == title).FirstOrDefault();

            }
        }
    }
}
