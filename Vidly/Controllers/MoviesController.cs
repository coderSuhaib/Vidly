using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ViewResult Index()
        {
            var movies = getMovie();
            return View(movies);
        }

        private IEnumerable<Movie> getMovie()
        {
            var movie = new List<Movie>
            {
                new Movie{ Id = 1, Name = "Fight Club"},
                new Movie{ Id = 2, Name = "Gladiator"}
            };
            return movie;
        }
    }
}