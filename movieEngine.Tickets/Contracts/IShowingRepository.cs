using System;
using System.Collections.Generic;
using movieEngine.Tickets.Models;

namespace movieEngine.Tickets.Contracts
{
    public interface IShowingRepository
    {
        IEnumerable<Showing> GetUpcomingMovieShowings(int movieId);    
    }   
}
