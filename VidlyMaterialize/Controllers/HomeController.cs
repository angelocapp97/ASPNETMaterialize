using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace VidlyMaterialize.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var context = new IdentityDbContext<IdentityUser>();
            var store = new UserStore<IdentityUser>(context);
            var manager = new UserManager<IdentityUser>(store);

            var email = "example@domain.com";
            var password = "passw0rd";

            var user = await manager.FindByEmailAsync(email);

            if (user == null)
            {
                user = new IdentityUser
                {
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