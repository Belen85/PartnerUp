using PartnerUp.Infra;
using PartnerUp.Models;
using PartnerUp.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartnerUp.Areas.Member.Controllers
{
    public class HomeController : Controller
    {
        UnitOfWork ctx = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
        //private void showconnecteduser()
        //{
        //    sessionutils.connecteduser;
        //}
        // GET: Member/Home


        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.ZoneMembre = "active";
            if (!SessionUtils.IsLogged) return RedirectToAction("Login", "Home", new { area = "" });
            SearchViewModel sv = new SearchViewModel();
            return View(sv);
        }

        [HttpPost]

        public ActionResult Index(SearchModel search)
        {
            if (SessionUtils.IsLogged)
            {
                    List<PresentationCardModel> lcm = ctx.CheckInfo(search);
                    if (lcm == null)  //Cest la meme chose que dire liste vide??? []
                    {  
                    ViewBag.ErrorMessage = "None results for this search";
                    return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                    SearchViewModel svm = new SearchViewModel();
                    svm.ListeCartes = lcm;
                    return View(svm);
                    }
            }
            else
            {
                Session.Abandon();

                return RedirectToAction("Login", "Home", new { area = "" });
            }

        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session.Abandon();

            return RedirectToAction("Login", "Home", new { area = "" });
        }

        [HttpGet]
        public ActionResult Profile()
        {
            

            if (SessionUtils.IsLogged)
            {
                ProfileViewModel pm = new ProfileViewModel();
                return View(pm);

            }
            else
            {
                Session.Abandon();

                return RedirectToAction("Login", "Home", new { area = "" });

            }
        
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Profile(CardModel card)
        {
            if (SessionUtils.IsLogged)
            {
                if (ModelState.IsValid)
                {
                    card.IdUser = SessionUtils.ConnectedUser.IdUser;

                    if (ctx.SaveCard(card))
                    {
                        ViewBag.SuccessMessage = "Your card has been registered";
                        return RedirectToAction("Profile", "Home");
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "None card has been created yet, try again";
                        ProfileViewModel pvm = new ProfileViewModel();
                        return View(pvm);
                    }
                }
                else
                {
                    ViewBag.ErrorMessage = "Card error";
                    ProfileViewModel pvm = new ProfileViewModel();
                    return View(pvm);
                }

            }
            else
            {
                Session.Abandon();

                return RedirectToAction("Login", "Home", new { area = "" });
            }


        }


        
    }

}