using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            var customers = new List<Customer>
            {
                new Customer {Name = "Cristiano Ronaldo"},
                new Customer {Name = "Lionel Messi"},
            };

            var ViewModel = new RandomMovieViewModel
            {
                Customers = customers
            };

            return View(ViewModel);
        }

        public ActionResult Details(int? id)
        {
            var customers = new List<Customer>
            {
                new Customer {Id=1, Name = "Cristiano Ronaldo"},
                new Customer {Id=2 ,Name = "Lionel Messi"},
            };

            Customer customer = customers.Where(p => p.Id == id).FirstOrDefault();

            var ViewModel = new RandomMovieViewModel
            {
                Customer = customer
            };

            return View(ViewModel);
        }
    }
}