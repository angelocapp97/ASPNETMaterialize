using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMaterialize.Models;

namespace VidlyMaterialize.Controllers
{
    public class CustomersController : Controller
    {
        private VidlyMaterializeContext _context;

        public CustomersController()
        {
            _context = new VidlyMaterializeContext();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.ToList();

            return View(customers);
        }
    }
}