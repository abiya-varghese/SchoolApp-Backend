using Assignment9.Models;
using Assignment9.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Assignment9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository movieRepository;
        public MovieController(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }
        [HttpGet,Route("GetAllMovies")]
        public IActionResult GetAll() {
            try
            {
               
                    List<Movie> movies = movieRepository.GetAllMovie();
                    return StatusCode(200, movies);
                
                
            }
            catch (Exception)
            {

                throw;
            }

        }
        [HttpGet,Route("GetMovieByActor/{actor}")]
        public IActionResult GetActor(string actor)
        {
            try
            {
                return StatusCode(200, movieRepository.GetMoviesByActor(actor));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet,Route("GetMovieByYear/{yr}")]
        public IActionResult GetYear(string yr) {
            try
            {
                return StatusCode(200, movieRepository.GetMoviesByReleaseYear(yr));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet,Route("GetMovieDirector/{direct}")]
        public IActionResult GetDirector(string direct) {

            try
            {
                return StatusCode(200, movieRepository.GetMoviesByDirector(direct));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpPost,Route("AddMovie")]
        public IActionResult AddM(Movie movie)
        {
            try
              {
                 if (ModelState.IsValid)
                 {
                 movieRepository.AddMovie(movie);
                  return StatusCode(200, movie);
                 }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet,Route("GetMovieByName/{name}")]
        public IActionResult MovieName(string name) {
            try
            {
                Movie movie = movieRepository.GetMoviesByName(name);
                if (movie != null)
                {
                    return StatusCode(200, movie);
                }
                else
                {
                    return StatusCode(404, new JsonResult("Invalid Movie Name"));
                }
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
    }
}
