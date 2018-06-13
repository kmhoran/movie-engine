using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Encodings.Web;

namespace movieEngine.Controllers.ApiControllers
{
    [Route("api/movies")]
    public class MoviesApiController: Controller
    {
        [HttpGet]
        public IActionResult GetAllMovies(){
            var movie = new Movie(){
                MovieId = 0,
                Title = "Casablanca",
                Year = 1942,
            };
            // string text = "text text";
            
            
            
            return Ok(movie);
        }
        
    }

    public class Movie{
        public int MovieId { get; set; }     
        public string Title { get; set; }    
        public int Year { get; set; }
        public IEnumerable<int> Numbers { get; set; }
    }
}