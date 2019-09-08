using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Customers()
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            return View(customers);
        }
        public ActionResult Movies()
        {
            var movies = new List<Movie>() {
                new Movie { Name = "Shrek!" },
                new Movie { Name = "The Accountant"}
            };
           return View(movies);
        }
    }
}