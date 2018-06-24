using System.Collections.Generic;
using movieEngine.Movies.Models;

namespace movieEngine.Movies.Data.Repositories
{
    public class InMemoryMovieRepository: IMovieRepository
    {
        private List<Movie> _movies;

        public InMemoryMovieRepository(){
            _movies = new List<Movie>{
                new Movie(
                    movieId:1, 
                    title:"Star Wars: The Last Jedi",
                    year:2017,
                    imagePath: "https://images-na.ssl-images-amazon.com/images/I/51poKKV63GL.jpg"),
                new Movie(
                    movieId:2,
                    title:"Baby Driver",
                    year:2017,
                    imagePath:"https://cdn3.digitalartsonline.co.uk/cmsdata/slideshow/3662115/baby-driver-rory-hi-res.jpg"
                ),
                new Movie(
                    movieId:3,
                    title:"Spider-Man: Homecoming",
                    year:2017,
                    imagePath:"http://www.joblo.com/posters/images/full/Spiderman-poster-7-large.jpg"
                ),
                new Movie(
                    movieId:4,
                    title:"Harry Potter and the Order of the Phoenix",
                    year:2007,
                    imagePath:"https://www.harrypottermovieposters.com/wp-content/uploads/2014/05/harry-potter-and-the-order-of-the-phoenix-movie-poster-2007-1020400773.jpg"
                )
            };
        }
        public IEnumerable<Movie> GetMovies(){
            return _movies;
        }
    }
}
