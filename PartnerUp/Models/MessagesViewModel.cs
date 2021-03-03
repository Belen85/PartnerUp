using PartnerUp.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace PartnerUp.Models
{
    public class MessagesViewModel
    {
        private UnitOfWork ctx = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

        private string _titleMessages;

        private List<ContactModel> _listeContacts;
       
        public MessagesViewModel()
        {
            TitleMessages = "Messages";

        }

        public string TitleMessages
        {
            get
            {
                return _titleMessages;
            }

            set
            {
                _titleMessages = value;
            }
        }

        public List<ContactModel> ListeContacts
        {
            get
            {
                return _listeContacts;
            }

            set
            {
                _listeContacts = value;
            }
        }

      
        
    }
}