using System;
using System.Collections.Generic;
using movieEngine.Movies.Models;
using movieEngine.Tickets.Models;

namespace movieEngine.Web.Models
{
    public class TicketsMovieViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Showing> Showings { get; set; }
    }
}