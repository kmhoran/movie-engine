using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movieEngine.Movies.Contracts;
using movieEngine.Web.Models;

namespace movieEngine.Web.Controllers
{
    public class HomeController : Controller
    {
        private IMovieRepository _movieRepo;

        public HomeController(IMovieRepository movieRepo)
        {
            _movieRepo = movieRepo;
        }
        public IActionResult Index()
        {
            var vm = new HomeIndexViewModel()
            {
                Movies = _movieRepo.GetMovies()
            };
            return View(vm);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
