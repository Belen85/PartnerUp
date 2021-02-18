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
        public ActionResult Index()
        {
            ViewBag.ZoneMembre = "active";
            if (!SessionUtils.IsLogged) return RedirectToAction("Login", "Home", new { area = "" });
            return View();
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
    }
}