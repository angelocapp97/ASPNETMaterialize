using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using VidlyMaterialize.Models;
using VidlyMaterialize.ViewModels;

namespace VidlyMaterialize.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.Gender).ToList();

            return View(customers);
        }

        public ActionResult New()
        {
            var genders = _context.Genders.ToList();
            var viewModel = new NewCustomerViewModel
            {
                Genders = genders
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewCustomerViewModel
                {
                    Customer = customer,
                    Genders = _context.Genders.ToList()
                };
                return View("New", viewModel);
            }

            _context.Customers.Add(customer);
            _context.SaveChanges();

            return RedirectToAction("index", "customers");
        }
    }
}