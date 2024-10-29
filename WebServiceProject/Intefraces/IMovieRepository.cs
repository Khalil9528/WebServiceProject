using WebServiceProject.Models;

namespace WebServiceProject.Intefraces
{
    public interface IMovieRepository
    {
        ICollection<Movie> GetMovies();
    }
}
