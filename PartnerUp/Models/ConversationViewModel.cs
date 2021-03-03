using PartnerUp.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace PartnerUp.Models
{
    public class ConversationViewModel
    {
        private UnitOfWork ctx = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

        private List<MessageModel> _listeMessages;

        public ConversationViewModel()
        {

        }

        public List<MessageModel> ListeMessages
        {
            get
            {
                return _listeMessages;
            }

            set
            {
                _listeMessages = value;
            }
        }
    }
}