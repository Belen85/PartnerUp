using PartnerUp.Infra;
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
        UnitOfWork ctx = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
        public ActionResult Index()
        {
            return View();
        }


        //Afficher page Register
        [HttpGet]
        public ActionResult Register()
        {
            ViewBag.Message = "Your register page.";
            RegisterLoginViewModel rm = new RegisterLoginViewModel();
            return View(rm);
        }

        //Envoi des donnees vers la data base
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Register(UserModel user)
        {
            if (ModelState.IsValid)
            {
                //UnitOfWork ctx = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
                if (ctx.SaveUser(user))
                {
                    ViewBag.SuccessMessage = "You have been registered";
                    return RedirectToAction("Login", "Home");
                }
                else
                {
                    ViewBag.ErrorMessage = "You have not been registered yet, try again";
                    RegisterLoginViewModel rm = new RegisterLoginViewModel();
                    return View(rm);
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Formulaire error";
                RegisterLoginViewModel rm = new RegisterLoginViewModel();
                return View(rm);
            }
        }


        //Afficher page Login
        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.Message = "Your login page.";
            RegisterLoginViewModel rm = new RegisterLoginViewModel();
            return View(rm);
        }

        //Envoi des donnees vers la data base
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Login(LoginModel lm)
        {
            if (ModelState.IsValid)
            {
                //UnitOfWork ctx = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
                UserModel um = ctx.UserAuth(lm);
                if (um == null)
                {
                    ViewBag.Error = "Erreur Login/Password";
                    RegisterLoginViewModel rm = new RegisterLoginViewModel();
                    return View(rm);
                }
                else
                {
                    SessionUtils.IsLogged = true;
                    SessionUtils.ConnectedUser = um;
                    return RedirectToAction("Index", "Home", new { area = "Member" });
                }


            }
            else
            {
                RegisterLoginViewModel rm = new RegisterLoginViewModel();
                return View(rm);
            }
            
        
        }
    }
}