using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private List<Customer> Customers = new List<Customer>
        {
            new Customer() { Id = 1, Name = "Joe" },
            new Customer() { Id = 2, Name = "Mama" }
        };
        // GET: Customers
        public ActionResult Index()
        {   
            return View(Customers);
        }
        public ActionResult Details(string id)
        {
            try
            {
                var customer = Customers.First(item => item.Id == int.Parse(id));
                return View(customer);
            }
            catch
            {
                throw new HttpException(404, "No customer.");
            }
        }
    }
}