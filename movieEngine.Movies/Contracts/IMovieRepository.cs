using System.Collections.Generic;
using movieEngine.Movies.Models;

namespace movieEngine.Movies.Contracts{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetMovies();
        Movie Get(int movieId);
    }
}
