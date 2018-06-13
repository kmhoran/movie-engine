using System.Collections.Generic;
using movieEngine.Movies.Models;

namespace movieEngine.Movies.Data.Repositories
{
    public class MovieRepository{
        public IEnumerable<Movie> GetMovies(){
            var movies = new List<Movie>() {
              new Movie(movieId: 0, title: "Casablanca!!!", year: 1942, imagePath: "#")
            };

            return movies;
        }
    }
}
