using WebServiceProject.Data;
using WebServiceProject.Models;

namespace WebServiceProject
{
    public class Seed
    {
        private readonly DataContext _context;
        public Seed(DataContext context)
        {
            _context = context;
        }

        public void SeedDataContext()
        {
            if (!_context.Movies.Any())
            {
                var movies = new List<Movie>()
                {
                    new Movie()
                    {
                        Title = "Inception",
                        ReleaseDate = new DateTime(2010, 7, 16),
                        Genres = new List<Genre>()
                        {
                            new Genre { Name = "Science Fiction" },
                            new Genre { Name = "Thriller" }
                        },
                        Reviews = new List<Review>()
                        {
                            new() { Title="Amazing", Text="Mind-blowing!", Rating=5, Reviewer = new User() { Pseudo="JohnDoe", Password="password123" } },
                            new Review { Title="Good", Text="Really enjoyed it", Rating=4, Reviewer = new User() { Pseudo="JaneDoe", Password="password456" } },
                        }
                    }
                };


                _context.Movies.AddRange(movies);
                _context.SaveChanges();
            }
        }
    }

}
