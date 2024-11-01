using WebServiceProject.Models;

namespace WebServiceProject.Intefraces
{
    public interface IMovieRepository
    {
        ICollection<Movie> GetMovies();
        Movie GetMovieById(int id);
        Movie GetMovieByTitle(string title);
       
    }
}
