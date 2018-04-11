using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using VidlyMaterialize.Models;

namespace VidlyMaterialize.Controllers
{
    public class HomeController : Controller
    {
        private VidlyMaterializeContext _context;

        public HomeController()
        {
            _context = new VidlyMaterializeContext();
        }

        public async Task<ActionResult> Index()
        {
            var store = new UserStore<CustomUser>(_context);
            var manager = new UserManager<CustomUser>(store);

            var name = "Angelo";
            var surname = "Cappelletti";
            var email = "example@domain.com";
            var password = "passw0rd";

            var user = await manager.FindByEmailAsync(email);

            if (user == null)
            {
                user = new CustomUser
                {
                    FirstName = name,
                    LastName = surname,
                    UserName = email,
                    Email = email
                };

                await manager.CreateAsync(user, password);
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contacts()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}