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

    }
}
