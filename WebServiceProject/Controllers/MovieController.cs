using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebServiceProject.Data;
using WebServiceProject.Intefraces;
using WebServiceProject.Models;
using WebServiceProject.Repository;

namespace WebServiceProject.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class MovieController : Controller
    {
        private readonly IMovieRepository _movieRepository;
        private readonly DataContext _context;
        public MovieController(IMovieRepository movieRepository, DataContext context)
        {
            _movieRepository = movieRepository;
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Movie>))]

        public IActionResult GetMovies()
        {
            var movies = _movieRepository.GetMovies();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(movies);
        }
        /*
        [HttpGet("{movieId}")]
        [ProducesResponseType(200, Type = typeof(Movie))]
        [ProducesResponseType(400)]

        public IActionResult GetMovie(int id)
        {
            var movie = _movieRepository.GetMovieById(id);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(movie);
        }
        */
        [HttpGet("{movieTitle}")]
        [ProducesResponseType(200, Type = typeof(Movie))]
        [ProducesResponseType(400)]

        public IActionResult GetMoGetMovieByTitle(string movieTitle)
        {
            var movie = _movieRepository.GetMovieByTitle(movieTitle);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(movie);

        }
        

     
    }
}
