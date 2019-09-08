using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customers = new List<Customer>
            {
                new Customer { Name = "Bob Eagle", Id = 1 },
                new Customer { Name = "Maggie Hawk", Id = 2 }
            };

        // GET: Customers
        public ActionResult Index()
        {
            if (customers.Count == 0)
                return Content("We don't have any customers yet");
            else
            return View(customers);
        }

        public ActionResult CustomerDetails(int Id)
        {
            return View(customers[Id - 1]);
        }
    }
}