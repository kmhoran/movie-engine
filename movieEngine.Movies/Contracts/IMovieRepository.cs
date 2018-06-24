using System.Collections.Generic;
using movieEngine.Movies.Models;

public interface IMovieRepository
{
    IEnumerable<Movie> GetMovies();
}