using PartnerUp.Models;
using PartnerUp.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartnerUp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //Afficher page Register
        [HttpGet]
        public ActionResult Register()
        {
            ViewBag.Message = "Your register page.";
            RegisterViewModel rm = new RegisterViewModel();
            return View(rm);
        }

        //Envoi des donnees vers la data base
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Register(UserModel user)
        {
            if (ModelState.IsValid)
            {
                UnitOfWork ctx = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
                if (ctx.SaveUser(user))
                {
                    ViewBag.SuccessMessage = "You have been registered";
                    return RedirectToAction("Login", "Home");
                }
                else
                {
                    ViewBag.ErrorMessage = "You have not been registered yet, try again";
                    RegisterViewModel rm = new RegisterViewModel();
                    return View(rm);
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Formulaire error";
                RegisterViewModel rm = new RegisterViewModel();
                return View(rm);
            }
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your login page.";

            return View();
        }
    }
}