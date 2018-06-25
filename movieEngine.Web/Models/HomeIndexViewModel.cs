using System.Collections.Generic;
using movieEngine.Movies.Models;

namespace movieEngine.Web.Models{
    public class HomeIndexViewModel
    {
        public IEnumerable<Movie> Movies { get; set; } 
    }
}
