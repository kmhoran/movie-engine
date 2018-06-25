using Microsoft.AspNetCore.Mvc;
using movieEngine.Movies.Contracts;
using movieEngine.Movies.Data.Repositories;
using System.Text.Encodings.Web;

namespace movieEngine.Web.Controllers.ApiControllers
{
    [Route("api/movies")]
    public class MoviesApiController: Controller
    {
        private IMovieRepository _movieRepo;

        public MoviesApiController(IMovieRepository movieRepo){
            _movieRepo = movieRepo;
        }

        [HttpGet]
        public IActionResult GetAllMovies(){
            return Ok(_movieRepo.GetMovies());
        }
    }
}