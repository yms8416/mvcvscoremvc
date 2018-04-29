using BilgeAdam.Northwind.NetData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeAdam.Northwind.MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerRepository repo;

        public CustomerController()
        {
            repo = new CustomerRepository();
        }
        public ActionResult Index()
        {
            var customers = repo.GetCustomers();
            return View(customers);
        }
    }
}