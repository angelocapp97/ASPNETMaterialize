using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using VidlyMaterialize.Models;
using VidlyMaterialize.ViewModels;

namespace VidlyMaterialize.Controllers
{
    public class HomeController : BaseController
    {
        public async Task<ActionResult> Index()
        {
            var name = "Angelo";
            var surname = "Cappelletti";
            var email = "example@domain.com";
            var password = "passw0rd";

            var user = await UserManager.FindByEmailAsync(email);

            if (user == null)
            {
                user = new CustomUser
                {
                    FirstName = name,
                    LastName = surname,
                    UserName = email,
                    Email = email
                };

                await UserManager.CreateAsync(user, password);
            }
            else
            {
                var result = await SignInManager.PasswordSignInAsync(user.UserName, password, true, false);

                if (result == SignInStatus.Success)
                {
                    var viewModel = new BaseViewModel
                    {
                        UserFirstName = user.FirstName,
                        UserLastName = user.LastName,
                        UserEmail = user.Email
                    };
                    return View(viewModel);
                }
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