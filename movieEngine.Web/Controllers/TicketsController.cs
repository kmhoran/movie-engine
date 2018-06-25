using Microsoft.AspNetCore.Mvc;
using movieEngine.Movies.Contracts;
using movieEngine.Tickets.Contracts;
using movieEngine.Web.Models;

namespace movieEngine.Web.Controllers
{
    public class TicketsController: Controller
    {
        private IMovieRepository _movieRepo;
        private IShowingRepository _showingRepo;

        public TicketsController(
            IMovieRepository movieRepo,
            IShowingRepository showingRepo){
            _movieRepo = movieRepo;
            _showingRepo = showingRepo;
        }

        public IActionResult Movie(int id)
        {
            var vm = new TicketsMovieViewModel();
            vm.Movie = _movieRepo.Get(id);
            vm.Showings = _showingRepo.GetUpcomingMovieShowings(id);
            return View(vm);
        }
    }
}