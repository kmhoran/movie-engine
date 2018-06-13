
using System.Collections.Generic;

namespace movieEngine.Movies.Models
{
public class Movie{
    public Movie(
        int movieId,
        string title,
        int year,
        string imagePath
    )
    {
        MovieId = movieId;
        Title = title;
        Year = year;
        ImagePath = imagePath;
    }
    public int MovieId { get; set; }     
    public string Title { get; set; }    
    public int Year { get; set; }
    public string ImagePath { get; set; }
}
}