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

        [HttpGet]

        public ActionResult Messages()
        {
            if (SessionUtils.IsLogged)
            {
                int IdUserFrom = SessionUtils.ConnectedUser.IdUser;
                List<ContactModel> lc = ctx.CheckContact(IdUserFrom);
                if (lc == null)
                {
                    return RedirectToAction("Messages", "Home");
                }
                else
                {
                    MessagesViewModel vm = new MessagesViewModel();
                    vm.ListeContacts = lc;
                    return View(vm);
                }
               
            }
            else
            {
                Session.Abandon();

                return RedirectToAction("Login", "Home", new { area = "" });
            }
        }

        [HttpPost]
        public ActionResult Messages(ContactModel contact)
        {
            if (SessionUtils.IsLogged)
            {
               
            return RedirectToAction("Conversation", "Home", new { id = contact.IdUserTo});
            }
            else
            {
                Session.Abandon();

                return RedirectToAction("Login", "Home", new { area = "" });
            }
        
        }

        [HttpGet]

        public ActionResult Conversation(ContactModel contact)
        {

            if (SessionUtils.IsLogged)
            {
                
                contact.IdUserFrom = SessionUtils.ConnectedUser.IdUser;
                string idUserTo = Request.Path.Substring(26);
                int idUserToInt = int.Parse(idUserTo);
                contact.IdUserTo = idUserToInt;
                List<MessageModel> lm = ctx.GetAllMessage(contact);
                ConversationViewModel cv = new ConversationViewModel();
                cv.ListeMessages = lm;
                return View(cv);
            }
            else
            {
                Session.Abandon();

                return RedirectToAction("Login", "Home", new { area = "" });
            }

        }

        [HttpPost]

        public ActionResult Conversation(SendMessageModel send, ContactModel contact)
        {
            if (SessionUtils.IsLogged)
            {
                //SendMessageModel
                send.IdUserFrom = SessionUtils.ConnectedUser.IdUser;
                string idUserTo = Request.Path.Substring(26);
                int idUserToInt = int.Parse(idUserTo);
                send.IdUserTo = idUserToInt;
                //ContactModel
                contact.IdUserFrom = SessionUtils.ConnectedUser.IdUser;
                contact.IdUserTo = idUserToInt;
                if (ctx.SaveMessage(send))
                {
                    ViewBag.SuccessMessage = "Your message has been sent";
                    List<MessageModel> lm = ctx.GetAllMessage(contact);
                    ConversationViewModel cv = new ConversationViewModel();
                    cv.ListeMessages = lm;
                    return View(cv);
                }
                else
                {
                    ViewBag.ErrorMessage = "Your message has not been sent, try again";
                    ConversationViewModel cv = new ConversationViewModel();
                    return View(cv);
                }
            }
            else
            {
                Session.Abandon();

                return RedirectToAction("Login", "Home", new { area = "" });
            }
        
        }

        [HttpGet]
        public ActionResult School()
        {
            ViewBag.ZoneMembre = "active";
            if (!SessionUtils.IsLogged) return RedirectToAction("Login", "Home", new { area = "" });
            SchoolViewModel svm = new SchoolViewModel();
            return View(svm);
        }

        [HttpPost]

        public ActionResult School(string City, int IdDance)
        {
            if (SessionUtils.IsLogged)
            {
                List<SchoolModel> lsm = ctx.checkSchool(City, IdDance);
                if (lsm == null)
                {
                    ViewBag.ErrorMessage = "None results for this search";
                    return RedirectToAction("School", "Home");
                }
                else
                {
                    SchoolViewModel svm = new SchoolViewModel();
                    svm.ListSchools = lsm;
                    return View(svm);
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