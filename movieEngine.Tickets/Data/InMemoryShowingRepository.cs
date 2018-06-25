using System;
using System.Collections.Generic;
using System.Linq;
using movieEngine.Tickets.Contracts;
using movieEngine.Tickets.Models;

namespace movieEngine.Tickets.Data
{
    public class InMemoryShowingRepository : IShowingRepository
    {
        private List<Showing> _showings;

        public InMemoryShowingRepository(){
            Random rnd = new Random();
            _showings = new List<Showing>();
            for(var i = 1; i < 5; i++)
            {
                var showing = new Showing() {
                    ShowingId = 1,
                    MovieId = 0,
                    StartTime = DateTime.Today.AddDays(1).AddHours((rnd.Next(0,10) + 11)),
                    TheaterId = rnd.Next(1,5),
                    TicketsSold = rnd.Next(0, 121)
                };
                _showings.Add(showing);
            }
        }
        public IEnumerable<Showing> GetUpcomingMovieShowings(int movieId)
        {
           var returnList = new List<Showing>();
           foreach(var showing in _showings){
               Showing newShowing = showing.MakeCopy();
               newShowing.MovieId = movieId;
               returnList.Add(newShowing);
           }
           return returnList.OrderBy(s => s.StartTime);
        }
    }
}