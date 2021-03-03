using PartnerUp.Infra;
using PartnerUp.Models;
using PartnerUp.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartnerUp.Controllers
{
    public class HomeController : Controller
    {
        private string[] valideImageType = { ".png", ".jpg", ".jpeg" };
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

        public ActionResult Register(UserModel user, HttpPostedFileBase FilePicture)
        {

            if (ModelState.IsValid)
            {
                //1- vérifier que la photo à une taille supérieure à 0 et pas trop lourde <200Mo
                if (FilePicture.ContentLength > 0 && FilePicture.ContentLength < 20000)
                {
                    //2 Vérifier le type
                    string extension = Path.GetExtension(FilePicture.FileName);
                    if (valideImageType.Contains(extension))
                    {
                        //3 vérifier si le dossier de destination existe
                        string destFolder = Path.Combine(Server.MapPath("~/img/dancers"));
                        if (!Directory.Exists(destFolder))
                        {
                            //string destFolderDancer = Path.Combine(Server.MapPath("~/img/dancers"), SessionUtils.ConnectedUser.IdUser.ToString());
                            Directory.CreateDirectory(Path.Combine(Server.MapPath("~/img/dancers"), SessionUtils.ConnectedUser.IdUser.ToString()));
                        }
                        //4 - Upload de l'image
                        FilePicture.SaveAs(Path.Combine(destFolder, FilePicture.FileName));
                        //5 Mise à jour de l'objet User
                        user.Image = FilePicture.FileName;
                    }
                }

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
                    return RedirectToAction("Profile", "Home", new { area = "Member" });
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