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
                var users = new List<User>
                {
                    new User
                    {
                        Pseudo = "KHALIL",
                        Password = "yourpassword",
                        UserRole = Role.Admin,
                        Reviews = new List<Review>
                        {
                            new Review
                            {
                                Title = "Amazing Movie!",
                                Text = "This movie blew my mind.",
                                Rating = 5,
                                Movie = new Movie
                                {
                                    Title = "Inception",
                                    ReleaseDate = new DateTime(2010, 7, 16)
                                }
                            },
                            new Review
                            {
                                Title = "Pretty good",
                                Text = "The story was compelling.",
                                Rating = 4,
                                Movie = new Movie
                                {
                                    Title = "Interstellar",
                                    ReleaseDate = new DateTime(2014, 11, 7)
                                }
                            }
                        }
                    }
                };
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
                            new() { Title="Good", Text="Really enjoyed it", Rating=4, Reviewer = new User() { Pseudo="JaneDoe", Password="password456" } }
                        }
                    },
                    new Movie()
                    {
                        Title = "The Dark Knight",
                        ReleaseDate = new DateTime(2008, 7, 18),
                        Genres = new List<Genre>()
                        {
                            new Genre { Name = "Action" },
                            new Genre { Name = "Drama" }
                        },
                        Reviews = new List<Review>()
                        {
                            new() { Title="Incredible", Text="Best superhero movie ever!", Rating=5, Reviewer = new User() { Pseudo="BruceWayne", Password="batman123" } },
                            new() { Title="Intense", Text="Loved the Joker's performance.", Rating=5, Reviewer = new User() { Pseudo="Alfred", Password="butler456" } }
                        }
                    },
                    new Movie()
                    {
                        Title = "Interstellar",
                        ReleaseDate = new DateTime(2014, 11, 7),
                        Genres = new List<Genre>()
                        {
                            new Genre { Name = "Science Fiction" },
                            new Genre { Name = "Adventure" }
                        },
                        Reviews = new List<Review>()
                        {
                            new() { Title="Breathtaking", Text="Amazing visuals and plot.", Rating=5, Reviewer = new User() { Pseudo="Cooper", Password="nasa123" } },
                            new() { Title="Complex", Text="A great space movie.", Rating=4, Reviewer = new User() { Pseudo="Brand", Password="prof456" } }
                        }
                    },
                    new Movie()
                    {
                        Title = "Pulp Fiction",
                        ReleaseDate = new DateTime(1994, 10, 14),
                        Genres = new List<Genre>()
                        {
                            new Genre { Name = "Crime" },
                            new Genre { Name = "Drama" }
                        },
                        Reviews = new List<Review>()
                        {
                            new() { Title="Classic", Text="A true masterpiece of cinema.", Rating=5, Reviewer = new User() { Pseudo="Vincent", Password="vega123" } },
                            new() { Title="Stylish", Text="Tarantino at his best.", Rating=4, Reviewer = new User() { Pseudo="Jules", Password="samuel456" } }
                        }
                    },
                    new Movie()
                    {
                        Title = "The Matrix",
                        ReleaseDate = new DateTime(1999, 3, 31),
                        Genres = new List<Genre>()
                        {
                            new Genre { Name = "Science Fiction" },
                            new Genre { Name = "Action" }
                        },
                        Reviews = new List<Review>()
                        {
                            new() { Title="Revolutionary", Text="Changed the game forever.", Rating=5, Reviewer = new User() { Pseudo="Neo", Password="matrix123" } },
                            new() { Title="Mind-bending", Text="Incredible action and philosophy.", Rating=4, Reviewer = new User() { Pseudo="Morpheus", Password="redpill456" } }
                        }
                    },
                    new Movie()
                    {
                        Title = "The Lord of the Rings: The Fellowship of the Ring",
                        ReleaseDate = new DateTime(2001, 12, 19),
                        Genres = new List<Genre>()
                        {
                            new Genre { Name = "Fantasy" },
                            new Genre { Name = "Adventure" }
                        },
                        Reviews = new List<Review>()
                        {
                            new() { Title="Epic", Text="An unforgettable journey.", Rating=5, Reviewer = new User() { Pseudo="Frodo", Password="ring123" } },
                            new() { Title="Amazing", Text="Best fantasy movie of all time.", Rating=5, Reviewer = new User() { Pseudo="Gandalf", Password="wizard456" } }
                        }
                    },
                    new Movie()
                    {
                        Title = "The Avengers",
                        ReleaseDate = new DateTime(2012, 5, 4),
                        Genres = new List<Genre>()
                        {
                            new Genre { Name = "Action" },
                            new Genre { Name = "Adventure" }
                        },
                        Reviews = new List<Review>()
                        {
                            new() { Title="Fun", Text="Amazing team-up!", Rating=5, Reviewer = new User() { Pseudo="IronMan", Password="stark123" } },
                            new() { Title="Entertaining", Text="Loved every bit of it.", Rating=4, Reviewer = new User() { Pseudo="Hulk", Password="smash456" } }
                        }
                    },
                    new Movie()
                    {
                        Title = "Titanic",
                        ReleaseDate = new DateTime(1997, 12, 19),
                        Genres = new List<Genre>()
                        {
                            new Genre { Name = "Drama" },
                            new Genre { Name = "Romance" }
                        },
                        Reviews = new List<Review>()
                        {
                            new() { Title="Heartbreaking", Text="A tragic love story.", Rating=5, Reviewer = new User() { Pseudo="Jack", Password="heart123" } },
                            new() { Title="Emotional", Text="Beautiful and devastating.", Rating=5, Reviewer = new User() { Pseudo="Rose", Password="rose456" } }
                        }
                    },
                    new Movie()
                    {
                        Title = "The Godfather",
                        ReleaseDate = new DateTime(1972, 3, 24),
                        Genres = new List<Genre>()
                        {
                            new Genre { Name = "Crime" },
                            new Genre { Name = "Drama" }
                        },
                        Reviews = new List<Review>()
                        {
                            new() { Title="Masterpiece", Text="The best mafia movie ever made.", Rating=5, Reviewer = new User() { Pseudo="Vito", Password="don123" } },
                            new() { Title="Brilliant", Text="Incredible storytelling and acting.", Rating=5, Reviewer = new User() { Pseudo="Michael", Password="corleone456" } }
                        }
                    },
                    new Movie()
                    {
                        Title = "Fight Club",
                        ReleaseDate = new DateTime(1999, 10, 15),
                        Genres = new List<Genre>()
                        {
                            new Genre { Name = "Drama" },
                            new Genre { Name = "Thriller" }
                        },
                        Reviews = new List<Review>()
                        {
                            new() { Title="Iconic", Text="A thought-provoking masterpiece.", Rating=5, Reviewer = new User() { Pseudo="Tyler", Password="durden123" } },
                            new() { Title="Mind-bending", Text="Loved the twist!", Rating=4, Reviewer = new User() { Pseudo="Narrator", Password="fight456" } }
                        }
                    },
                    new Movie()
                    {
                        Title = "Gladiator",
                        ReleaseDate = new DateTime(2000, 5, 5),
                        Genres = new List<Genre>()
                        {
                            new Genre { Name = "Action" },
                            new Genre { Name = "Drama" }
                        },
                        Reviews = new List<Review>()
                        {
                            new() { Title="Epic", Text="An unforgettable performance by Russell Crowe.", Rating=5, Reviewer = new User() { Pseudo="Maximus", Password="gladiator123" } },
                            new() { Title="Gripping", Text="Loved the action scenes.", Rating=4, Reviewer = new User() { Pseudo="Commodus", Password="empire456" } }
                        }
                    }
                };

                _context.Movies.AddRange(movies);
                _context.SaveChanges();
            }
        }
    }
}
