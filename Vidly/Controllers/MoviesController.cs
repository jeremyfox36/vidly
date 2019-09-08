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
        List<Movie> movies = new List<Movie>() {
                new Movie { Name = "Shrek!" },
                new Movie { Name = "The Accountant"}
            };

        // GET: Movies
        public ActionResult Index()
        {
            return View(movies);
        }
    }
}