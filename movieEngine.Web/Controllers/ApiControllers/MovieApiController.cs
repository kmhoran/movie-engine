using Microsoft.AspNetCore.Mvc;
using movieEngine.Movies.Data.Repositories;
using System.Text.Encodings.Web;

namespace movieEngine.Web.Controllers.ApiControllers
{
    [Route("api/movies")]
    public class MoviesApiController: Controller
    {
        [HttpGet]
        public IActionResult GetAllMovies(){
            
            // string text = "text text";
            var movieRepo = new MovieRepository();
            var movies = movieRepo.GetMovies();
            
            return Ok(movies);
        }
        
    }


}